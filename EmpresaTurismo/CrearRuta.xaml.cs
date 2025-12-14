namespace EmpresaTurismo;

public partial class CrearRuta : ContentPage
{
    DatosMock datosMock = App.lRutas;

    public CrearRuta()
    {
        InitializeComponent();
    }

    private async void NuevaRuta(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(IdEntry.Text) ||
            string.IsNullOrWhiteSpace(NombreEntry.Text) ||
            string.IsNullOrWhiteSpace(DistanciaEntry.Text) ||
            string.IsNullOrWhiteSpace(DesnivelEntry.Text) ||
            string.IsNullOrWhiteSpace(ProvinciaEntry.Text) ||
            DificultadPicker.SelectedIndex == -1)
        
        {
            await DisplayAlert("Faltan datos", "Por favor, rellena todos los campos.", "OK");
            return;
        }

        string id = IdEntry.Text.Trim();
        string nombre = NombreEntry.Text.Trim();
        string ndistancia = DistanciaEntry.Text.Trim();
        string ndesnivel = DesnivelEntry.Text.Trim();
        string provincia = ProvinciaEntry.Text.Trim();
        string ndificultad = DificultadPicker.SelectedItem.ToString();

        if (!double.TryParse(ndistancia, out double distanciaKm))
        {
            await DisplayAlert("Error", "Distancia no válida.", "OK");
            return;
        }

        if (!double.TryParse(ndesnivel, out double desnivel))
        {
            await DisplayAlert("Error", "Desnivel no válido.", "OK");
            return;
        }

        if (!Enum.TryParse<Dificultad>(ndificultad, out Dificultad dificultad))
        {
            await DisplayAlert("Error", "Dificultad no válida.", "OK");
            return;
        }

        bool circular = CircularSwitch.IsToggled;

        DateTime fechaApertura = FechaAperturaPicker.Date;

        List<string> etiquetas = new List<string>();

        if (!string.IsNullOrWhiteSpace(EtiquetasEntry.Text))
        {
            etiquetas = EtiquetasEntry.Text
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim())
                .Where(t => t.Length > 0)
                .ToList();
        }

        if (datosMock.Any(r => r.Id.Equals(id, StringComparison.OrdinalIgnoreCase)))
        {
            await DisplayAlert("Error", "Ya existe una ruta con ese identificador.", "OK");
            return;
        }

        Ruta nuevaRuta = new Ruta(
            id,
            nombre,
            dificultad,
            distanciaKm,
            desnivel,
            provincia,
            circular,
            fechaApertura,
            etiquetas
        );

        datosMock.Add(nuevaRuta);

        LimpiarFormulario();
        await DisplayAlert("Éxito", "Ruta creada correctamente.", "OK");
        
    }

    private void LimpiarFormulario()
    {
        IdEntry.Text = NombreEntry.Text = DistanciaEntry.Text = DesnivelEntry.Text = ProvinciaEntry.Text = EtiquetasEntry.Text = string.Empty;
        DificultadPicker.SelectedIndex = -1;
        CircularSwitch.IsToggled = false;
        FechaAperturaPicker.Date = DateTime.Today;
    }
}