namespace EmpresaTurismo;

public partial class DetalleRuta : ContentPage
{

	private readonly Ruta _ruta;

	public DetalleRuta()
	{
		InitializeComponent();
	}

	public DetalleRuta(Ruta ruta)
    {
        InitializeComponent();
        _ruta = ruta;
        BindingContext = _ruta;

        if (_ruta.Etiquetas != null && _ruta.Etiquetas.Any())
        {
            EtiquetasLabel.Text = string.Join(", ", _ruta.Etiquetas);
        }
        else
        {
            EtiquetasLabel.Text = "Sin etiquetas";
        }
    }

    private async void Volver(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}