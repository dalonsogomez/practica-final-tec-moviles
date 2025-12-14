namespace EmpresaTurismo;

public partial class MostrarRutasEstadisticas : ContentPage
{
    public MostrarRutasEstadisticas()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        CargarEstadisticas();
    }

    private void ActualizarEstadisticas(object sender, EventArgs e)
    {
        CargarEstadisticas();
    }

    private void CargarEstadisticas()
    {
        var rutas = App.lRutas;

        if (rutas == null || rutas.Count == 0)
        {
            TotalRutasLabel.Text = "0";
            DistanciaMediaLabel.Text = "N/A";
            RutaMasLargaNombreLabel.Text = "No hay rutas";
            RutaMasLargaKmLabel.Text = "";
            RutaMasCortaNombreLabel.Text = "No hay rutas";
            RutaMasCortaKmLabel.Text = "";
            MayorDesnivelNombreLabel.Text = "No hay rutas";
            MayorDesnivelMetrosLabel.Text = "";
            MenorDesnivelNombreLabel.Text = "No hay rutas";
            MenorDesnivelMetrosLabel.Text = "";
            return;
        }

        // Total de rutas
        int totalRutas = rutas.Count;
        TotalRutasLabel.Text = totalRutas.ToString();

        // Distancia media
        double distanciaMedia = rutas.Average(r => r.DistanciaKm);
        DistanciaMediaLabel.Text = $"{distanciaMedia:F2} km";

        // Ruta más larga
        Ruta rutaMasLarga = rutas.OrderByDescending(r => r.DistanciaKm).First();
        RutaMasLargaNombreLabel.Text = rutaMasLarga.Nombre;
        RutaMasLargaKmLabel.Text = $"{rutaMasLarga.DistanciaKm} km - {rutaMasLarga.Provincia}";

        // Ruta más corta
        Ruta rutaMasCorta = rutas.OrderBy(r => r.DistanciaKm).First();
        RutaMasCortaNombreLabel.Text = rutaMasCorta.Nombre;
        RutaMasCortaKmLabel.Text = $"{rutaMasCorta.DistanciaKm} km - {rutaMasCorta.Provincia}";

        // Mayor desnivel
        Ruta mayorDesnivel = rutas.OrderByDescending(r => r.Desnivel).First();
        MayorDesnivelNombreLabel.Text = mayorDesnivel.Nombre;
        MayorDesnivelMetrosLabel.Text = $"{mayorDesnivel.Desnivel} m - {mayorDesnivel.Provincia}";

        // Menor desnivel
        Ruta menorDesnivel = rutas.OrderBy(r => r.Desnivel).First();
        MenorDesnivelNombreLabel.Text = menorDesnivel.Nombre;
        MenorDesnivelMetrosLabel.Text = $"{menorDesnivel.Desnivel} m - {menorDesnivel.Provincia}";
    }
}