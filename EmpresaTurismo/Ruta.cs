namespace EmpresaTurismo;

public enum Dificultad {FACIL, MEDIA, DIFICIL}

public class Ruta
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public Dificultad DificultadRuta { get; set; }
    public double DistanciaKm { get; set; }
    public double Desnivel { get; set; }
    public string Provincia { get; set; }
    public bool Circular { get; set; }
    public DateTime FechaApertura { get; set; }
    public List<string> Etiquetas { get; set; }

    public Ruta (string id, string nombre, Dificultad dificultadRuta,
                 double distanciaKm, double desnivel,
                 string provincia, bool circular,
                 DateTime fechaApertura, List<string> etiquetas)
    {
        Id = id;
        Nombre = nombre;
        DificultadRuta = dificultadRuta;
        DistanciaKm = distanciaKm;
        Desnivel = desnivel;
        Provincia = provincia;
        Circular = circular;
        FechaApertura = fechaApertura;
        Etiquetas = etiquetas;
    }

}