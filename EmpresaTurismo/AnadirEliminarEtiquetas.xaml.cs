namespace EmpresaTurismo;

public partial class AnadirEliminarEtiquetas : ContentPage
{
    DatosMock datosMock = App.lRutas;

    public AnadirEliminarEtiquetas()
    {
        InitializeComponent();
    }

    private Ruta? BuscarRutaPorIdDesdeFormulario()
    {
        string id = IdEntry.Text?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(id))
            return null;

        return datosMock.FirstOrDefault(r =>
            r.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
    }
    private void RefrescarVistaRuta(Ruta? ruta)
    {
        if (ruta is null)
        {
            InfoRutaLabel.Text = "Ruta no encontrada";
            EtiquetasListView.ItemsSource = null;
        }
        else
        {
            InfoRutaLabel.Text =
                $"{ruta.Id} - {ruta.Nombre} ({ruta.DificultadRuta}) - {ruta.Provincia}";

            EtiquetasListView.ItemsSource = null;
            EtiquetasListView.ItemsSource = ruta.Etiquetas;
        }
    }

    private async void BuscarRuta(object sender, EventArgs e)
    {
        var ruta = BuscarRutaPorIdDesdeFormulario();

        if (ruta is null)
            await DisplayAlert("Error", "No se ha encontrado ninguna ruta con ese Id.", "OK");

        RefrescarVistaRuta(ruta);
    }

    private async void AñadirEtiquetas(object sender, EventArgs e)
    {
        var ruta = BuscarRutaPorIdDesdeFormulario();

        if (ruta is null)
        {
            await DisplayAlert("Error", "Primero introduce un Id de ruta válido y pulsa en 'Buscar ruta'.", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(NuevasEtiquetasEntry.Text))
        {
            await DisplayAlert("Error", "Introduce al menos una etiqueta.", "OK");
            return;
        }

        if (ruta!.Etiquetas == null)
            ruta.Etiquetas = new List<string>();

        var nuevas = NuevasEtiquetasEntry.Text
            .Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(t => t.Trim())
            .Where(t => t.Length > 0)
            .ToList();

        bool anyAdded = false;

        foreach (var et in nuevas)
        {
            bool yaExiste = ruta!.Etiquetas
                .Any(e => e.Equals(et, StringComparison.OrdinalIgnoreCase));

            if (!yaExiste)
            {
                ruta.Etiquetas.Add(et);
                anyAdded = true;
            }
        }

        if (!anyAdded)
            await DisplayAlert("Info", "No se ha añadido ninguna etiqueta nueva (ya existían).", "OK");
        else
            await DisplayAlert("Éxito", "Etiquetas añadidas correctamente.", "OK");

        NuevasEtiquetasEntry.Text = string.Empty;
        RefrescarVistaRuta(ruta);
    }

    private async void EliminarEtiqueta(object sender, EventArgs e)
    {
        var ruta = BuscarRutaPorIdDesdeFormulario();

        if (ruta is null)
        {
            await DisplayAlert("Error", "Primero introduce un Id de ruta válido y pulsa en 'Buscar ruta'.", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(EtiquetaEliminarEntry.Text))
        {
            await DisplayAlert("Error", "Introduce la etiqueta a eliminar.", "OK");
            return;
        }

        if (ruta!.Etiquetas == null || ruta.Etiquetas.Count == 0)
        {
            await DisplayAlert("Error", "La ruta no tiene etiquetas que eliminar.", "OK");
            return;
        }

        string etiqueta = EtiquetaEliminarEntry.Text.Trim();

        int antes = ruta.Etiquetas.Count;

        ruta.Etiquetas.RemoveAll(e => e.Equals(etiqueta, StringComparison.OrdinalIgnoreCase));

        if (ruta.Etiquetas.Count == antes)
            await DisplayAlert("Info", "Esa etiqueta no existe en la ruta.", "OK");
        else
            await DisplayAlert("Éxito", "Etiqueta eliminada correctamente.", "OK");

        EtiquetaEliminarEntry.Text = string.Empty;
        RefrescarVistaRuta(ruta);
    }
}