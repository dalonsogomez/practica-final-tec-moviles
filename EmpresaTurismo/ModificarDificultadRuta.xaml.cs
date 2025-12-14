namespace EmpresaTurismo;

public partial class ModificarDificultadRuta : ContentPage
{
    public ModificarDificultadRuta()
    {
        InitializeComponent();
    }

    private Ruta? BuscarRuta()
    {
        string id = IdEntry.Text?.Trim() ?? string.Empty;
        string nombre = NombreEntry.Text?.Trim() ?? string.Empty;
        string provincia = ProvinciaEntry.Text?.Trim() ?? string.Empty;


        if (!string.IsNullOrWhiteSpace(id))
        {
            return App.lRutas.FirstOrDefault(r =>
                r.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

    
        if (!string.IsNullOrWhiteSpace(nombre) &&
            !string.IsNullOrWhiteSpace(provincia))
        {
            return App.lRutas.FirstOrDefault(r =>
                r.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase) &&
                r.Provincia.Equals(provincia, StringComparison.OrdinalIgnoreCase));
        }

      
        return null;
    }

    private async void ModificarDificultad(object sender, EventArgs e)
    {
        if (DificultadPicker.SelectedIndex == -1)
        {
            await DisplayAlert("Error", "Selecciona la nueva dificultad.", "OK");
            return;
        }

        var ruta = BuscarRuta();

        if (ruta == null)
        {
            await DisplayAlert("Error",
                "No se ha encontrado ninguna ruta. Introduce un Id o bien Nombre y Provincia.",
                "OK");
            return;
        }

        string? dificultadTexto = DificultadPicker.SelectedItem?.ToString();

        if (string.IsNullOrEmpty(dificultadTexto) || !Enum.TryParse<Dificultad>(dificultadTexto, out Dificultad nuevaDificultad))
        {
            await DisplayAlert("Error", "Dificultad no válida.", "OK");
            return;
        }

        ruta.DificultadRuta = nuevaDificultad;

        await DisplayAlert("Éxito",
            $"Se ha actualizado la dificultad de la ruta '{ruta.Nombre}' a {nuevaDificultad}.",
            "OK");
    }
}