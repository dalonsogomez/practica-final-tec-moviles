namespace EmpresaTurismo;

public partial class MostrarRutas : ContentPage
{
	public MostrarRutas()
	{
		InitializeComponent();
		RutasListView.ItemsSource = App.lRutas.MostrarRutas();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        RutasListView.ItemsSource = App.lRutas.MostrarRutas();
    }

    private async void RutasListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var collection = (CollectionView)sender;

        var rutaSeleccionada = e.CurrentSelection.FirstOrDefault() as Ruta;
        if (rutaSeleccionada == null)
            return;

    
        await Navigation.PushAsync(new DetalleRuta(rutaSeleccionada));
        collection.SelectedItem = null;
    }

}