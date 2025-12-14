# 📚 Referencia de API y Clases

Esta página documenta todas las clases, métodos y componentes principales de EmpresaTurismo.

## 🏛️ Namespace: EmpresaTurismo

Todo el código de la aplicación está bajo el namespace `EmpresaTurismo`.

## 📦 Clases Principales

### App (Application)

Clase principal de la aplicación que hereda de `Microsoft.Maui.Controls.Application`.

**Ubicación**: `App.xaml.cs`

#### Propiedades Estáticas

```csharp
public static DatosMock lRutas { get; set; }
```
- **Descripción**: Instancia singleton del almacén de rutas
- **Tipo**: DatosMock
- **Acceso**: Público, estático
- **Uso**: Acceder desde cualquier parte de la aplicación como `App.lRutas`

#### Constructor

```csharp
public App()
```
- **Descripción**: Inicializa la aplicación
- **Acciones**:
  - Inicializa componentes XAML
  - Crea instancia de DatosMock
  - Rellena con datos de ejemplo
  - Establece AppShell como página principal

**Ejemplo de uso**:
```csharp
// Acceder a las rutas desde cualquier página
var todasLasRutas = App.lRutas;
```

---

### AppShell (Shell)

Contenedor de navegación principal de la aplicación.

**Ubicación**: `AppShell.xaml` / `AppShell.xaml.cs`

#### Estructura

```xml
<TabBar>
    <Tab Route="MainPage" Icon="inicio.png">
        <ShellContent ContentTemplate="{DataTemplate local:MainPage}" />
    </Tab>
    <!-- Más pestañas... -->
</TabBar>
```

#### Rutas de Navegación

| Ruta | Página | Descripción |
|------|--------|-------------|
| `MainPage` | MainPage | Página de inicio |
| `CrearRuta` | CrearRuta | Crear nueva ruta |
| `MostrarRutas` | MostrarRutas | Listado de rutas |
| `MostrarRutasProvincia` | MostrarRutasProvincias | Filtro por provincia |
| `MostrarRutasEstadisticas` | MostrarRutasEstadisticas | Estadísticas |
| `MostrarRutasEtiquetas` | MostrarRutasEtiquetas | Filtro por etiquetas |
| `ModificarRuta` | AnadirEliminarEtiquetas | Gestión de etiquetas |
| `ModificarDificultadRuta` | ModificarDificultadRuta | Modificar dificultad |
| `EliminarRuta` | EliminarRuta | Eliminar ruta |

---

### Ruta (Model)

Clase que representa una ruta de senderismo.

**Ubicación**: `Ruta.cs`

#### Propiedades

```csharp
public string Id { get; set; }
public string Nombre { get; set; }
public Dificultad DificultadRuta { get; set; }
public double DistanciaKm { get; set; }
public double Desnivel { get; set; }
public string Provincia { get; set; }
public bool Circular { get; set; }
public DateTime FechaApertura { get; set; }
public List<string> Etiquetas { get; set; }
```

#### Constructor

```csharp
public Ruta(string id, string nombre, Dificultad dificultadRuta,
            double distanciaKm, double desnivel, string provincia, 
            bool circular, DateTime fechaApertura, List<string> etiquetas)
```

**Parámetros**:
- `id`: Identificador único
- `nombre`: Nombre descriptivo
- `dificultadRuta`: Nivel de dificultad (enum)
- `distanciaKm`: Distancia en kilómetros
- `desnivel`: Desnivel acumulado en metros
- `provincia`: Provincia de ubicación
- `circular`: Si es circular o lineal
- `fechaApertura`: Fecha de inauguración
- `etiquetas`: Lista de palabras clave

**Ejemplo**:
```csharp
Ruta ruta = new Ruta(
    "R007",
    "Camino del Pastor",
    Dificultad.MEDIA,
    8.5,
    450,
    "León",
    true,
    new DateTime(2024, 3, 15),
    new List<string> { "Montaña", "Pastos" }
);
```

---

### Dificultad (Enum)

Enumeración de niveles de dificultad.

**Ubicación**: `Ruta.cs`

```csharp
public enum Dificultad 
{ 
    FACIL, 
    MEDIA, 
    DIFICIL 
}
```

**Valores**:
- `FACIL`: Rutas fáciles
- `MEDIA`: Rutas moderadas
- `DIFICIL`: Rutas difíciles

**Uso**:
```csharp
// Asignación
Dificultad nivel = Dificultad.MEDIA;

// Conversión desde string
Enum.TryParse<Dificultad>("FACIL", out Dificultad dif);

// Conversión a string
string texto = Dificultad.MEDIA.ToString(); // "MEDIA"
```

---

### DatosMock (ObservableCollection<Ruta>)

Colección observable que almacena todas las rutas.

**Ubicación**: `DatosMock.cs`

#### Herencia

```csharp
public class DatosMock : ObservableCollection<Ruta>
```

#### Métodos

##### Rellenar()

```csharp
public void Rellenar()
```
- **Descripción**: Carga 6 rutas de ejemplo en la colección
- **Parámetros**: Ninguno
- **Retorna**: void
- **Uso**: Se llama automáticamente al iniciar la app

##### MostrarRutas()

```csharp
public DatosMock MostrarRutas()
```
- **Descripción**: Devuelve la instancia actual
- **Parámetros**: Ninguno
- **Retorna**: DatosMock (this)
- **Uso**: Para compatibilidad y encadenamiento

#### Métodos Heredados (de ObservableCollection)

```csharp
// Añadir
void Add(Ruta item)

// Eliminar
bool Remove(Ruta item)

// Limpiar
void Clear()

// Contar
int Count { get; }

// Indexar
Ruta this[int index] { get; set; }
```

**Ejemplo de uso**:
```csharp
var rutas = App.lRutas;

// Añadir
rutas.Add(nuevaRuta);

// Buscar
var ruta = rutas.FirstOrDefault(r => r.Id == "R001");

// Filtrar
var rutasFaciles = rutas.Where(r => r.DificultadRuta == Dificultad.FACIL);

// Eliminar
rutas.Remove(ruta);

// Contar
int total = rutas.Count;
```

---

## 📄 Páginas (ContentPages)

### MainPage

Página de bienvenida de la aplicación.

**Ubicación**: `MainPage.xaml` / `MainPage.xaml.cs`

#### Constructor

```csharp
public MainPage()
```

**Contenido UI**:
- Imagen de fondo (rutasenderismo.png)
- Mensaje de bienvenida

---

### CrearRuta

Formulario para crear nuevas rutas.

**Ubicación**: `CrearRuta.xaml` / `CrearRuta.xaml.cs`

#### Propiedades

```csharp
DatosMock datosMock = App.lRutas;
```

#### Constructor

```csharp
public CrearRuta()
```

#### Métodos

##### NuevaRuta (Event Handler)

```csharp
private async void NuevaRuta(object sender, EventArgs e)
```
- **Descripción**: Maneja el evento de creación de ruta
- **Validaciones**:
  - Verifica campos obligatorios
  - Valida formato de números
  - Comprueba ID único
- **Acciones**:
  - Crea nueva instancia de Ruta
  - Añade a DatosMock
  - Limpia formulario
  - Muestra confirmación

##### LimpiarFormulario()

```csharp
private void LimpiarFormulario()
```
- **Descripción**: Resetea todos los campos del formulario
- **Parámetros**: Ninguno
- **Retorna**: void

**Campos del formulario**:
- IdEntry (Entry)
- NombreEntry (Entry)
- DificultadPicker (Picker)
- DistanciaEntry (Entry)
- DesnivelEntry (Entry)
- ProvinciaEntry (Entry)
- CircularSwitch (Switch)
- FechaAperturaPicker (DatePicker)
- EtiquetasEntry (Entry)

---

### MostrarRutas

Muestra el listado completo de rutas.

**Ubicación**: `MostrarRutas.xaml` / `MostrarRutas.xaml.cs`

#### Métodos del Ciclo de Vida

##### OnAppearing()

```csharp
protected override void OnAppearing()
```
- **Descripción**: Se ejecuta al mostrar la página
- **Acciones**: Actualiza la vista con los datos actuales

#### Navegación

```csharp
// Al seleccionar una ruta, navega a DetalleRuta
await Shell.Current.GoToAsync($"DetalleRuta?Id={ruta.Id}");
```

---

### DetalleRuta

Muestra los detalles completos de una ruta.

**Ubicación**: `DetalleRuta.xaml` / `DetalleRuta.xaml.cs`

#### Propiedades con QueryProperty

```csharp
[QueryProperty(nameof(RutaId), "Id")]
public string RutaId 
{ 
    get; 
    set; 
}
```
- **Descripción**: Recibe el ID de la ruta desde la navegación
- **Tipo**: string
- **Actualiza**: La UI cuando se establece

#### Métodos

##### CargarDetalles()

```csharp
private void CargarDetalles()
```
- **Descripción**: Busca y muestra los detalles de la ruta
- **Usa**: RutaId para buscar en App.lRutas

---

### MostrarRutasEstadisticas

Muestra estadísticas agregadas de las rutas.

**Ubicación**: `MostrarRutasEstadisticas.xaml` / `MostrarRutasEstadisticas.xaml.cs`

#### Métodos

##### OnAppearing()

```csharp
protected override void OnAppearing()
```
- **Descripción**: Carga estadísticas al mostrar la página

##### ActualizarEstadisticas (Event Handler)

```csharp
private void ActualizarEstadisticas(object sender, EventArgs e)
```
- **Descripción**: Botón para refrescar estadísticas manualmente

##### CargarEstadisticas()

```csharp
private void CargarEstadisticas()
```
- **Descripción**: Calcula y muestra las estadísticas
- **Estadísticas calculadas**:
  - Total de rutas
  - Distancia media
  - Ruta más larga
  - Ruta más corta
  - Mayor desnivel
  - Menor desnivel

**Cálculos utilizados**:
```csharp
int totalRutas = rutas.Count;
double distanciaMedia = rutas.Average(r => r.DistanciaKm);
Ruta rutaMasLarga = rutas.OrderByDescending(r => r.DistanciaKm).First();
Ruta rutaMasCorta = rutas.OrderBy(r => r.DistanciaKm).First();
Ruta mayorDesnivel = rutas.OrderByDescending(r => r.Desnivel).First();
Ruta menorDesnivel = rutas.OrderBy(r => r.Desnivel).First();
```

---

### MostrarRutasProvincias

Filtra y muestra rutas por provincia.

**Ubicación**: `MostrarRutasProvincias.xaml` / `MostrarRutasProvincias.xaml.cs`

#### Métodos

##### OnAppearing()

```csharp
protected override void OnAppearing()
```
- **Descripción**: Carga lista de provincias únicas

##### BuscarPorProvincia (Event Handler)

```csharp
private void BuscarPorProvincia(object sender, EventArgs e)
```
- **Descripción**: Filtra rutas por provincia seleccionada
- **Filtro**: `rutas.Where(r => r.Provincia == provinciaSeleccionada)`

---

### MostrarRutasEtiquetas

Filtra y muestra rutas por etiquetas.

**Ubicación**: `MostrarRutasEtiquetas.xaml` / `MostrarRutasEtiquetas.xaml.cs`

#### Métodos

##### BuscarPorEtiqueta (Event Handler)

```csharp
private void BuscarPorEtiqueta(object sender, EventArgs e)
```
- **Descripción**: Busca rutas que contengan la etiqueta especificada
- **Filtro**: `rutas.Where(r => r.Etiquetas.Contains(etiqueta))`
- **Validación**: Verifica que la etiqueta no esté vacía

---

### ModificarDificultadRuta

Permite cambiar la dificultad de una ruta.

**Ubicación**: `ModificarDificultadRuta.xaml` / `ModificarDificultadRuta.xaml.cs`

#### Métodos

##### CambiarDificultad (Event Handler)

```csharp
private async void CambiarDificultad(object sender, EventArgs e)
```
- **Descripción**: Actualiza la dificultad de la ruta seleccionada
- **Validaciones**:
  - Ruta seleccionada
  - Nueva dificultad seleccionada
- **Confirmación**: Diálogo de confirmación antes de cambiar

**Flujo**:
1. Seleccionar ruta del Picker
2. Mostrar dificultad actual
3. Seleccionar nueva dificultad
4. Confirmar cambio
5. Actualizar ruta

---

### AnadirEliminarEtiquetas

Gestiona las etiquetas de las rutas.

**Ubicación**: `AnadirEliminarEtiquetas.xaml` / `AnadirEliminarEtiquetas.xaml.cs`

#### Métodos

##### AnadirEtiqueta (Event Handler)

```csharp
private async void AnadirEtiqueta(object sender, EventArgs e)
```
- **Descripción**: Añade una nueva etiqueta a la ruta
- **Validaciones**:
  - Ruta seleccionada
  - Etiqueta no vacía
  - Etiqueta no duplicada
- **Acción**: Añade a `ruta.Etiquetas`

##### EliminarEtiqueta (Event Handler)

```csharp
private async void EliminarEtiqueta(object sender, EventArgs e)
```
- **Descripción**: Elimina la etiqueta seleccionada
- **Validaciones**:
  - Ruta seleccionada
  - Etiqueta seleccionada en el ListView
- **Acción**: Elimina de `ruta.Etiquetas`

##### CargarEtiquetas()

```csharp
private void CargarEtiquetas()
```
- **Descripción**: Actualiza la lista de etiquetas en la UI
- **Llamado**: Cuando se selecciona una ruta

---

### EliminarRuta

Permite eliminar rutas del sistema.

**Ubicación**: `EliminarRuta.xaml` / `EliminarRuta.xaml.cs`

#### Métodos

##### BorrarRuta (Event Handler)

```csharp
private async void BorrarRuta(object sender, EventArgs e)
```
- **Descripción**: Elimina la ruta seleccionada
- **Validación**: Ruta seleccionada
- **Confirmación**: Diálogo de confirmación
- **Acción**: `App.lRutas.Remove(ruta)`

**Flujo**:
1. Seleccionar ruta del Picker
2. Mostrar información de la ruta
3. Pulsar botón "Eliminar"
4. Confirmar en diálogo
5. Eliminar de la colección

---

### VerRuta

Vista detallada de una ruta específica.

**Ubicación**: `VerRuta.xaml` / `VerRuta.xaml.cs`

Similar a DetalleRuta pero con un diseño diferente.

---

## 🔧 Utilidades LINQ

### Consultas Comunes

```csharp
var rutas = App.lRutas;

// Filtrar por dificultad
var faciles = rutas.Where(r => r.DificultadRuta == Dificultad.FACIL);

// Filtrar por provincia
var leon = rutas.Where(r => r.Provincia == "León");

// Filtrar por etiqueta
var montana = rutas.Where(r => r.Etiquetas.Contains("Montaña"));

// Ordenar por distancia
var ordenadas = rutas.OrderBy(r => r.DistanciaKm);

// Buscar por ID
var ruta = rutas.FirstOrDefault(r => r.Id == "R001");

// Estadísticas
int count = rutas.Count;
double avg = rutas.Average(r => r.DistanciaKm);
double sum = rutas.Sum(r => r.DistanciaKm);
var max = rutas.Max(r => r.Desnivel);
var min = rutas.Min(r => r.Desnivel);

// Agrupar por provincia
var grupos = rutas.GroupBy(r => r.Provincia);

// Verificar existencia
bool existe = rutas.Any(r => r.Id == "R001");

// Todas cumplen condición
bool todasFaciles = rutas.All(r => r.DificultadRuta == Dificultad.FACIL);
```

## 🎨 Controles XAML Utilizados

### Controles de Entrada
- `Entry`: Campos de texto
- `Picker`: Listas desplegables
- `Switch`: Interruptores on/off
- `DatePicker`: Selector de fechas

### Controles de Visualización
- `Label`: Textos
- `CollectionView`: Listas de elementos
- `ListView`: Listas con selección
- `Frame`: Contenedores con borde
- `Image`: Imágenes

### Controles de Layout
- `StackLayout`: Apilado vertical/horizontal
- `Grid`: Diseño en cuadrícula
- `ScrollView`: Contenedor desplazable
- `VerticalStackLayout`: Apilado vertical

### Controles de Acción
- `Button`: Botones

## 🔗 Referencias API

- [.NET MAUI Application](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.application)
- [ContentPage](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.contentpage)
- [Shell](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.shell)
- [ObservableCollection](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1)
- [LINQ](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
