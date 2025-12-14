namespace EmpresaTurismo;

public partial class MostrarRutasEtiquetas : ContentPage
{
	public MostrarRutasEtiquetas()
	{
		InitializeComponent();
	}

    private async void BuscarPorEtiqueta(object sender, EventArgs e)
    {
        string etiqueta = EtiquetaEntry.Text?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(etiqueta))
        {
            await DisplayAlert("Error", "Introduce una etiqueta.", "OK");
            return;
        }

       
        List<Ruta> rutasEtiqueta = App.lRutas
            .Where(r => r.Etiquetas != null &&
                        r.Etiquetas.Any(et =>
                            et.Equals(etiqueta, StringComparison.OrdinalIgnoreCase)))
            .ToList();

        RutasListView.ItemsSource = rutasEtiqueta;

        if (rutasEtiqueta.Count == 0)
        {
            ResumenLabel.Text = $"No hay rutas con la etiqueta \"{etiqueta}\".";
        }
        else
        {
            ResumenLabel.Text = $"Total de rutas con la etiqueta \"{etiqueta}\": {rutasEtiqueta.Count}";
        }
    }
}