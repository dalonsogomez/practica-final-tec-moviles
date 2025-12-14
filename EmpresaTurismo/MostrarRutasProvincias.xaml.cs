namespace EmpresaTurismo;

public partial class MostrarRutasProvincias : ContentPage
{
	public MostrarRutasProvincias()
	{
		InitializeComponent();
	}

    private async void BuscarRutas(object sender, EventArgs e)
    {
        string provincia = ProvinciaEntry.Text?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(provincia))
        {
            await DisplayAlert("Error", "Introduce una provincia.", "OK");
            return;
        }

       
        List<Ruta> rutasProvincia = App.lRutas
            .Where(r => r.Provincia.Equals(provincia, StringComparison.OrdinalIgnoreCase))
            .ToList();

        RutasListView.ItemsSource = rutasProvincia;

        if (rutasProvincia.Count == 0)
        {
            ResumenLabel.Text = $"No hay rutas registradas en la provincia de {provincia}.";
        }
        else
        {
            ResumenLabel.Text = $"Total de rutas en {provincia}: {rutasProvincia.Count}";
        }
    }

}