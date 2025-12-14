# 📊 Modelo de Datos

Esta página documenta el modelo de datos utilizado en EmpresaTurismo.

## 🗂️ Visión General

El modelo de datos de EmpresaTurismo es simple y está compuesto por:
- Una clase principal: **Ruta**
- Una enumeración: **Dificultad**
- Una colección observable: **DatosMock**

## 📝 Clase: Ruta

La clase `Ruta` representa una ruta de senderismo con todas sus características.

### Definición Completa

```csharp
namespace EmpresaTurismo;

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
```

### Propiedades Detalladas

#### Id (string)
- **Propósito**: Identificador único de la ruta
- **Formato recomendado**: "R" + número secuencial (ej: R001, R002, R003)
- **Restricciones**: 
  - Debe ser único en el sistema
  - No puede estar vacío
  - Sensible a mayúsculas/minúsculas
- **Ejemplo**: `"R001"`, `"R042"`, `"RUTA_SPECIAL_01"`

#### Nombre (string)
- **Propósito**: Nombre descriptivo de la ruta
- **Restricciones**: 
  - No puede estar vacío
  - Recomendado: entre 5 y 100 caracteres
- **Ejemplos**: 
  - `"Senda del Bosque Encantado"`
  - `"Ascenso al Pico Alto"`
  - `"Ruta de las Cascadas"`

#### DificultadRuta (Dificultad)
- **Propósito**: Nivel de dificultad de la ruta
- **Tipo**: Enumeración `Dificultad`
- **Valores posibles**: 
  - `Dificultad.FACIL`: Rutas accesibles, poco desnivel, cortas
  - `Dificultad.MEDIA`: Rutas moderadas, desnivel medio, distancia media
  - `Dificultad.DIFICIL`: Rutas exigentes, mucho desnivel, largas distancias
- **Criterios sugeridos**:
  - FACIL: < 7 km, < 300m desnivel
  - MEDIA: 7-15 km, 300-800m desnivel
  - DIFICIL: > 15 km, > 800m desnivel

#### DistanciaKm (double)
- **Propósito**: Longitud total de la ruta en kilómetros
- **Tipo**: Número decimal (double)
- **Restricciones**: 
  - Debe ser mayor que 0
  - Precisión recomendada: 1 decimal
- **Rango típico**: 1.0 - 50.0 km
- **Ejemplos**: `6.5`, `14.2`, `18.0`

#### Desnivel (double)
- **Propósito**: Desnivel acumulado positivo en metros
- **Tipo**: Número decimal (double)
- **Restricciones**: 
  - Debe ser mayor o igual a 0
  - Generalmente sin decimales
- **Rango típico**: 0 - 3000 metros
- **Ejemplos**: `250`, `1200`, `1500`

#### Provincia (string)
- **Propósito**: Provincia donde se encuentra la ruta
- **Restricciones**: No puede estar vacío
- **Provincias de ejemplo**:
  - `"Ávila"`
  - `"León"`
  - `"Burgos"`
  - `"Salamanca"`
  - `"Segovia"`
  - `"Valladolid"`
- **Nota**: Permite cualquier provincia de España

#### Circular (bool)
- **Propósito**: Indica si la ruta es circular (inicio y fin en el mismo punto)
- **Valores**:
  - `true`: Ruta circular (vuelves al punto de inicio)
  - `false`: Ruta lineal (punto de inicio diferente al final)
- **Consideraciones**:
  - Las rutas circulares no requieren transporte de vuelta
  - Las rutas lineales pueden requerir dos vehículos o transporte público

#### FechaApertura (DateTime)
- **Propósito**: Fecha en la que se inauguró o abrió la ruta
- **Tipo**: DateTime de .NET
- **Formato de almacenamiento**: Fecha completa
- **Formato de visualización**: Generalmente día/mes/año
- **Ejemplos**: 
  - `new DateTime(2020, 3, 1)` → 01/03/2020
  - `new DateTime(2018, 7, 15)` → 15/07/2018

#### Etiquetas (List<string>)
- **Propósito**: Palabras clave para categorizar y buscar rutas
- **Tipo**: Lista de strings
- **Características**:
  - Puede estar vacía (List sin elementos)
  - Número ilimitado de etiquetas
  - Sin duplicados (responsabilidad de la aplicación)
- **Ejemplos de etiquetas**:
  - Geográficas: `"Montaña"`, `"Valle"`, `"Costa"`
  - Características: `"Río"`, `"Cascadas"`, `"Bosque"`, `"Prados"`
  - Dificultad: `"Técnica"`, `"Familiar"`, `"Expertos"`
  - Actividades: `"Bici"`, `"Running"`, `"Senderismo"`
  - Vistas: `"Panorámica"`, `"Cumbre"`, `"Mirador"`
  - Distancia: `"Larga distancia"`, `"Corta"`, `"Media"`
  - Época: `"Primavera"`, `"Verano"`, `"Otoño"`, `"Invierno"`

### Constructor

El constructor requiere todos los parámetros para crear una ruta:

```csharp
Ruta nuevaRuta = new Ruta(
    "R007",                           // id
    "Camino del Pastor",              // nombre
    Dificultad.MEDIA,                 // dificultadRuta
    8.5,                              // distanciaKm
    450,                              // desnivel
    "León",                           // provincia
    true,                             // circular
    new DateTime(2024, 3, 15),       // fechaApertura
    new List<string> { "Montaña", "Pastos", "Panorámica" }  // etiquetas
);
```

## 🎯 Enumeración: Dificultad

Define los niveles de dificultad disponibles para clasificar rutas.

### Definición

```csharp
public enum Dificultad 
{
    FACIL, 
    MEDIA, 
    DIFICIL
}
```

### Valores

| Valor | Descripción | Características Típicas |
|-------|-------------|------------------------|
| `FACIL` | Ruta fácil, apta para principiantes | < 7 km, < 300m desnivel, terreno suave |
| `MEDIA` | Ruta moderada, requiere algo de experiencia | 7-15 km, 300-800m desnivel, terreno variado |
| `DIFICIL` | Ruta exigente, para senderistas experimentados | > 15 km, > 800m desnivel, terreno técnico |

### Uso

```csharp
// Asignación directa
Dificultad nivel = Dificultad.MEDIA;

// En constructor
Ruta ruta = new Ruta(..., Dificultad.DIFICIL, ...);

// Parsing desde string
Enum.TryParse<Dificultad>("FACIL", out Dificultad dificultad);

// Comparación
if (ruta.DificultadRuta == Dificultad.FACIL)
{
    // Ruta fácil
}

// ToString para UI
string texto = ruta.DificultadRuta.ToString(); // "FACIL", "MEDIA", "DIFICIL"
```

## 🗄️ Clase: DatosMock

Colección observable que actúa como almacén de datos en memoria.

### Definición

```csharp
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
```

### Características

- **Herencia**: Extiende `ObservableCollection<Ruta>`
- **Notificaciones**: Emite eventos automáticamente cuando se añaden/eliminan elementos
- **Data Binding**: Compatible con XAML para actualización automática de UI
- **Métodos**:
  - `Rellenar()`: Carga 6 rutas de ejemplo
  - `MostrarRutas()`: Devuelve la propia instancia (para compatibilidad)

### Uso en la Aplicación

```csharp
// En App.xaml.cs - Singleton
public static DatosMock lRutas { get; set; }

public App()
{
    InitializeComponent();
    lRutas = new DatosMock();
    lRutas.Rellenar();  // Carga datos de ejemplo
    MainPage = new AppShell();
}

// En cualquier página
DatosMock rutas = App.lRutas;

// Operaciones CRUD
rutas.Add(nuevaRuta);           // Crear
var ruta = rutas.First(r => r.Id == "R001");  // Leer
ruta.DificultadRuta = Dificultad.MEDIA;       // Actualizar
rutas.Remove(ruta);              // Eliminar

// Consultas LINQ
var rutasFaciles = rutas.Where(r => r.DificultadRuta == Dificultad.FACIL);
var rutasLeon = rutas.Where(r => r.Provincia == "León");
double distanciaMedia = rutas.Average(r => r.DistanciaKm);
```

## 📈 Diagramas

### Diagrama de Clase UML

```
┌────────────────────────────────┐
│          <<enum>>              │
│         Dificultad             │
├────────────────────────────────┤
│ FACIL                          │
│ MEDIA                          │
│ DIFICIL                        │
└────────────────────────────────┘
              △
              │ uses
              │
┌────────────────────────────────┐
│           Ruta                 │
├────────────────────────────────┤
│ - Id: string                   │
│ - Nombre: string               │
│ - DificultadRuta: Dificultad   │
│ - DistanciaKm: double          │
│ - Desnivel: double             │
│ - Provincia: string            │
│ - Circular: bool               │
│ - FechaApertura: DateTime      │
│ - Etiquetas: List<string>      │
├────────────────────────────────┤
│ + Ruta(...)                    │
└────────────────────────────────┘
              △
              │ contains
              │
┌────────────────────────────────┐
│         DatosMock              │
├────────────────────────────────┤
│ Inherits:                      │
│ ObservableCollection<Ruta>     │
├────────────────────────────────┤
│ + Rellenar(): void             │
│ + MostrarRutas(): DatosMock    │
└────────────────────────────────┘
```

### Relaciones de Datos

```
App (Singleton)
    │
    └─── lRutas: DatosMock
            │
            ├─── Ruta 1 (R001)
            ├─── Ruta 2 (R002)
            ├─── Ruta 3 (R003)
            ├─── Ruta 4 (R004)
            ├─── Ruta 5 (R005)
            └─── Ruta 6 (R006)
```

## 🔍 Operaciones Comunes

### Crear una Ruta

```csharp
Ruta nuevaRuta = new Ruta(
    "R007",
    "Mi Nueva Ruta",
    Dificultad.MEDIA,
    10.5,
    500,
    "Ávila",
    true,
    DateTime.Now,
    new List<string> { "Montaña", "Bosque" }
);

App.lRutas.Add(nuevaRuta);
```

### Buscar una Ruta por ID

```csharp
Ruta ruta = App.lRutas.FirstOrDefault(r => r.Id == "R001");
if (ruta != null)
{
    // Ruta encontrada
}
```

### Filtrar Rutas

```csharp
// Por dificultad
var rutasFaciles = App.lRutas.Where(r => r.DificultadRuta == Dificultad.FACIL).ToList();

// Por provincia
var rutasLeon = App.lRutas.Where(r => r.Provincia == "León").ToList();

// Por etiqueta
var rutasMontana = App.lRutas.Where(r => r.Etiquetas.Contains("Montaña")).ToList();

// Por distancia
var rutasCortas = App.lRutas.Where(r => r.DistanciaKm < 10).ToList();

// Circulares
var rutasCirculares = App.lRutas.Where(r => r.Circular).ToList();
```

### Estadísticas

```csharp
// Total de rutas
int total = App.lRutas.Count;

// Distancia media
double media = App.lRutas.Average(r => r.DistanciaKm);

// Ruta más larga
Ruta masLarga = App.lRutas.OrderByDescending(r => r.DistanciaKm).First();

// Ruta más corta
Ruta masCorta = App.lRutas.OrderBy(r => r.DistanciaKm).First();

// Mayor desnivel
Ruta mayorDesnivel = App.lRutas.OrderByDescending(r => r.Desnivel).First();

// Distancia total
double distanciaTotal = App.lRutas.Sum(r => r.DistanciaKm);
```

### Modificar una Ruta

```csharp
Ruta ruta = App.lRutas.FirstOrDefault(r => r.Id == "R001");
if (ruta != null)
{
    // Modificar dificultad
    ruta.DificultadRuta = Dificultad.MEDIA;
    
    // Añadir etiqueta
    if (!ruta.Etiquetas.Contains("Nueva"))
    {
        ruta.Etiquetas.Add("Nueva");
    }
    
    // Eliminar etiqueta
    ruta.Etiquetas.Remove("Antigua");
}
```

### Eliminar una Ruta

```csharp
Ruta ruta = App.lRutas.FirstOrDefault(r => r.Id == "R001");
if (ruta != null)
{
    App.lRutas.Remove(ruta);
}
```

## 💾 Persistencia

### Estado Actual
- **Almacenamiento**: Solo en memoria (RAM)
- **Persistencia**: No hay - los datos se pierden al cerrar la app
- **Datos iniciales**: 6 rutas de ejemplo se cargan al iniciar

### Limitaciones
- ❌ Los cambios no se guardan entre sesiones
- ❌ Rutas creadas se pierden al cerrar la app
- ❌ Modificaciones no persisten
- ❌ No hay sincronización entre dispositivos

### Evolución Futura
Posibles mejoras para persistencia:
1. **SQLite Local**: Base de datos local embebida
2. **Preferencias**: Guardar en Preferences API de MAUI
3. **Archivos JSON**: Serializar a archivos locales
4. **API REST**: Backend con base de datos remota
5. **Azure/Firebase**: Servicios cloud con sincronización

## 📐 Reglas de Validación

### Validaciones Implementadas

| Campo | Validación |
|-------|------------|
| Id | No vacío, único en el sistema |
| Nombre | No vacío |
| Distancia | > 0, número válido |
| Desnivel | ≥ 0, número válido |
| Provincia | No vacío |
| Dificultad | Valor válido del enum |
| Circular | Booleano (true/false) |
| FechaApertura | Fecha válida |
| Etiquetas | Lista (puede estar vacía) |

### Validaciones Recomendadas (no implementadas)

- Distancia máxima razonable (ej: < 100 km)
- Desnivel máximo razonable (ej: < 5000 m)
- Longitud mínima/máxima del nombre
- Formato del ID (patrón regex)
- Etiquetas sin duplicados
- Fecha de apertura no en el futuro

## 🔗 Referencias

Para más información sobre las clases utilizadas:
- [ObservableCollection](https://learn.microsoft.com/es-es/dotnet/api/system.collections.objectmodel.observablecollection-1)
- [DateTime](https://learn.microsoft.com/es-es/dotnet/api/system.datetime)
- [List<T>](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1)
- [Enumerations](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/enum)
