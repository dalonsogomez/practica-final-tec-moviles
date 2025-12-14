using System.Collections.ObjectModel;

namespace EmpresaTurismo;

public class DatosMock : ObservableCollection<Ruta>
{
    public void Rellenar()
    {
        this.Add(new Ruta("R001", "Senda del Bosque Encantado",   Dificultad.FACIL,   6.5,  250,   "Ávila",      true,  new DateTime(2020, 3, 1),  new List<string> { "Bosque", "Familiar", "Río" }));
        this.Add(new Ruta("R002", "Ascenso al Pico Alto",         Dificultad.DIFICIL, 14.2, 1200,  "León",       false, new DateTime(2018, 7, 15), new List<string> { "Montaña", "Cumbre", "Panorámica" }));
        this.Add(new Ruta("R003", "Ruta de las Cascadas",         Dificultad.MEDIA,    9.8,  600,  "Burgos",     true,  new DateTime(2019, 5, 10), new List<string> { "Cascadas", "Río", "Sombras" }));
        this.Add(new Ruta("R004", "Sendero del Valle Escondido",  Dificultad.FACIL,    4.3,  150,  "Salamanca",  false, new DateTime(2021, 9, 20), new List<string> { "Valle", "Familiar", "Primavera" }));
        this.Add(new Ruta("R005", "Cresterío de la Sierra Norte", Dificultad.DIFICIL, 18.0, 1500,  "Segovia",    true,  new DateTime(2017, 10, 5), new List<string> { "Larga distancia", "Técnica", "Cresterío" }));
        this.Add(new Ruta("R006", "Vía Verde del Río Tranquilo",  Dificultad.MEDIA,   12.0,  300,  "Valladolid", false, new DateTime(2022, 4, 12), new List<string> { "Río", "Llano", "Bici" }));
    }

    public DatosMock MostrarRutas()
    {
        return this;
    }
}