namespace EmpresaTurismo;

public partial class EliminarRuta : ContentPage
{
    private Ruta? _rutaEncontrada;

    public EliminarRuta()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LimpiarFormulario();
    }

    private void LimpiarFormulario()
    {
        IdEntry.Text = string.Empty;
        InfoFrame.IsVisible = false;
        EliminarButton.IsVisible = false;
        _rutaEncontrada = null;
    }

    private async void BuscarRuta(object sender, EventArgs e)
    {
        string id = IdEntry.Text?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(id))
        {
            await DisplayAlert("Error", "Introduce el identificador de la ruta.", "OK");
            return;
        }

        _rutaEncontrada = App.lRutas.FirstOrDefault(r =>
            r.Id.Equals(id, StringComparison.OrdinalIgnoreCase));

        if (_rutaEncontrada == null)
        {
            await DisplayAlert("Error", $"No se ha encontrado ninguna ruta con el Id '{id}'.", "OK");
            InfoFrame.IsVisible = false;
            EliminarButton.IsVisible = false;
            return;
        }

        InfoRutaLabel.Text = $"{_rutaEncontrada.Nombre}";
        DetallesRutaLabel.Text = $"Id: {_rutaEncontrada.Id}\n" +
                                  $"Provincia: {_rutaEncontrada.Provincia}\n" +
                                  $"Dificultad: {_rutaEncontrada.DificultadRuta}\n" +
                                  $"Distancia: {_rutaEncontrada.DistanciaKm} km";

        InfoFrame.IsVisible = true;
        EliminarButton.IsVisible = true;
    }

    private async void EliminarRutaClick(object sender, EventArgs e)
    {
        if (_rutaEncontrada == null)
        {
            await DisplayAlert("Error", "No hay ninguna ruta seleccionada para eliminar.", "OK");
            return;
        }

        bool confirmar = await DisplayAlert("Confirmar eliminación",
            $"¿Estás seguro de que deseas eliminar la ruta '{_rutaEncontrada.Nombre}'?",
            "Sí, eliminar", "Cancelar");

        if (!confirmar)
            return;

        App.lRutas.Remove(_rutaEncontrada);

        await DisplayAlert("Éxito", $"La ruta '{_rutaEncontrada.Nombre}' ha sido eliminada correctamente.", "OK");

        LimpiarFormulario();
    }
}