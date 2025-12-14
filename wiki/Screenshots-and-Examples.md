# 📸 Capturas de Pantalla y Ejemplos

Esta página muestra ejemplos visuales y de código de EmpresaTurismo.

## 📱 Capturas de Pantalla de la Aplicación

### Pantalla Principal (Home)

La pantalla de bienvenida muestra una imagen de fondo de senderismo con un mensaje de bienvenida.

**Características**:
- Imagen de fondo full-screen
- Mensaje de bienvenida centrado en un frame
- Barra de navegación inferior con 5 pestañas

**Código XAML**:
```xml
<Grid>
    <Image Source="rutasenderismo.png"
           Aspect="AspectFill"
           VerticalOptions="FillAndExpand"
           HorizontalOptions="FillAndExpand"/>
        
    <VerticalStackLayout Spacing="10" 
                         VerticalOptions="Center" 
                         HorizontalOptions="Center">
        <Frame BackgroundColor="#CCFFFFFF" 
               CornerRadius="20"
               Padding="20,10"
               HasShadow="True"
               BorderColor="#2E7D32"
               TranslationY="-20">
            <Label Text="Bienvenido a tu Aventura"
                   FontSize="22"
                   FontAttributes="Bold, Italic"
                   TextColor="#2E7D32" 
                   HorizontalOptions="Center"/>
        </Frame>
    </VerticalStackLayout>
</Grid>
```

### Barra de Navegación

**5 Pestañas Principales**:
1. 🏠 **Inicio** - Pantalla de bienvenida
2. ➕ **Crear Ruta** - Formulario de creación
3. 👁️ **Ver Rutas** - Visualización y consultas
4. ✏️ **Modificar Ruta** - Edición de rutas
5. 🗑️ **Eliminar Ruta** - Eliminación de rutas

### Crear Ruta

**Formulario completo con todos los campos**:

**Campos del formulario**:
- ID (Entry)
- Nombre (Entry)
- Dificultad (Picker: FACIL, MEDIA, DIFICIL)
- Distancia en km (Entry numérico)
- Desnivel en m (Entry numérico)
- Provincia (Entry)
- Circular (Switch: Sí/No)
- Fecha de Apertura (DatePicker)
- Etiquetas (Entry, separadas por comas)

**Ejemplo de datos**:
```
ID: R007
Nombre: Camino del Pastor
Dificultad: MEDIA
Distancia: 8.5 km
Desnivel: 450 m
Provincia: León
Circular: Sí
Fecha de Apertura: 15/03/2024
Etiquetas: Montaña, Pastos, Panorámica
```

### Ver Rutas - Listado Completo

**CollectionView mostrando todas las rutas**:

Cada elemento de la lista muestra:
- Nombre de la ruta (en negrita)
- Provincia
- Dificultad (color-coded)
- Distancia en km

**Ejemplo de código XAML**:
```xml
<CollectionView ItemsSource="{Binding Source={x:Static local:App.lRutas}}">
    <CollectionView.ItemTemplate>
        <DataTemplate>
            <Frame Margin="10" Padding="15" HasShadow="True">
                <VerticalStackLayout>
                    <Label Text="{Binding Nombre}" 
                           FontSize="18" 
                           FontAttributes="Bold"/>
                    <Label Text="{Binding Provincia}" 
                           TextColor="Gray"/>
                    <Label Text="{Binding DificultadRuta}" 
                           FontAttributes="Italic"/>
                    <Label Text="{Binding DistanciaKm, StringFormat='{0} km'}"/>
                </VerticalStackLayout>
            </Frame>
        </DataTemplate>
    </CollectionView.ItemTemplate>
</CollectionView>
```

### Detalle de Ruta

**Vista completa de una ruta individual**:

Muestra todos los campos:
- 📝 **Nombre**: Senda del Bosque Encantado
- 🆔 **ID**: R001
- 🎯 **Dificultad**: FACIL
- 📏 **Distancia**: 6.5 km
- ⛰️ **Desnivel**: 250 m
- 📍 **Provincia**: Ávila
- 🔄 **Tipo**: Circular
- 📅 **Fecha de Apertura**: 01/03/2020
- 🏷️ **Etiquetas**: Bosque, Familiar, Río

### Ver Estadísticas

**Métricas del sistema**:

```
┌─────────────────────────────────┐
│  📊 ESTADÍSTICAS DE RUTAS       │
├─────────────────────────────────┤
│  Total de Rutas: 6              │
│  Distancia Media: 10.97 km      │
├─────────────────────────────────┤
│  🥇 Ruta Más Larga              │
│  Cresterío de la Sierra Norte   │
│  18.0 km - Segovia              │
├─────────────────────────────────┤
│  🥉 Ruta Más Corta              │
│  Sendero del Valle Escondido    │
│  4.3 km - Salamanca             │
├─────────────────────────────────┤
│  ⛰️ Mayor Desnivel              │
│  Cresterío de la Sierra Norte   │
│  1500 m - Segovia               │
├─────────────────────────────────┤
│  🏔️ Menor Desnivel              │
│  Sendero del Valle Escondido    │
│  150 m - Salamanca              │
└─────────────────────────────────┘
```

### Filtrar por Provincia

**Selector de provincia y resultados**:

```
Provincia: [Picker: León        ▼]
          [Botón: Buscar]

Resultados:
┌─────────────────────────────────┐
│ Ascenso al Pico Alto            │
│ León - DIFICIL - 14.2 km        │
└─────────────────────────────────┘
```

### Filtrar por Etiquetas

**Campo de búsqueda y resultados**:

```
Etiqueta: [Montaña              ]
         [Botón: Buscar por Etiqueta]

Resultados:
┌─────────────────────────────────┐
│ Ascenso al Pico Alto            │
│ 14.2 km - León - DIFICIL        │
├─────────────────────────────────┤
│ Camino del Pastor               │
│ 8.5 km - León - MEDIA           │
└─────────────────────────────────┘
```

### Modificar Dificultad

**Selección de ruta y nueva dificultad**:

```
Ruta: [Picker: R001 - Senda del Bosque Encantado ▼]

Dificultad Actual: FACIL

Nueva Dificultad: [Picker: MEDIA ▼]

[Botón: Modificar Dificultad]
```

### Añadir/Eliminar Etiquetas

**Gestión de etiquetas de una ruta**:

```
Ruta: [Picker: R001 - Senda del Bosque Encantado ▼]

Añadir Etiqueta:
[Entry: Nueva etiqueta           ]
[Botón: Añadir Etiqueta]

Etiquetas Actuales:
┌─────────────────────────────────┐
│ • Bosque                        │
│ • Familiar                      │
│ • Río                           │
└─────────────────────────────────┘

[Botón: Eliminar Etiqueta Seleccionada]
```

### Eliminar Ruta

**Selección y confirmación de eliminación**:

```
Ruta a Eliminar: [Picker: R004 - Sendero del Valle Escondido ▼]

Información de la Ruta:
┌─────────────────────────────────┐
│ Nombre: Sendero del Valle       │
│         Escondido               │
│ Provincia: Salamanca            │
│ Dificultad: FACIL               │
│ Distancia: 4.3 km               │
└─────────────────────────────────┘

[Botón: Eliminar Ruta]
```

## 💻 Ejemplos de Código

### Ejemplo 1: Crear una Ruta Programáticamente

```csharp
// Crear una nueva ruta
Ruta nuevaRuta = new Ruta(
    "R007",                                    // ID
    "Camino del Pastor",                       // Nombre
    Dificultad.MEDIA,                          // Dificultad
    8.5,                                       // Distancia en km
    450,                                       // Desnivel en metros
    "León",                                    // Provincia
    true,                                      // Circular
    new DateTime(2024, 3, 15),                // Fecha de apertura
    new List<string> { "Montaña", "Pastos", "Panorámica" }  // Etiquetas
);

// Añadir al almacén de datos
App.lRutas.Add(nuevaRuta);
```

### Ejemplo 2: Buscar Rutas

```csharp
// Buscar por ID
Ruta ruta = App.lRutas.FirstOrDefault(r => r.Id == "R001");

// Buscar por dificultad
var rutasFaciles = App.lRutas.Where(r => r.DificultadRuta == Dificultad.FACIL).ToList();

// Buscar por provincia
var rutasLeon = App.lRutas.Where(r => r.Provincia == "León").ToList();

// Buscar por etiqueta
var rutasMontana = App.lRutas.Where(r => r.Etiquetas.Contains("Montaña")).ToList();

// Buscar por distancia
var rutasCortas = App.lRutas.Where(r => r.DistanciaKm < 10).ToList();

// Buscar rutas circulares
var rutasCirculares = App.lRutas.Where(r => r.Circular).ToList();
```

### Ejemplo 3: Modificar una Ruta

```csharp
// Buscar la ruta
Ruta ruta = App.lRutas.FirstOrDefault(r => r.Id == "R001");

if (ruta != null)
{
    // Modificar dificultad
    ruta.DificultadRuta = Dificultad.MEDIA;
    
    // Añadir etiqueta
    if (!ruta.Etiquetas.Contains("Aventura"))
    {
        ruta.Etiquetas.Add("Aventura");
    }
    
    // Eliminar etiqueta
    ruta.Etiquetas.Remove("Antigua");
}
```

### Ejemplo 4: Calcular Estadísticas

```csharp
var rutas = App.lRutas;

// Total de rutas
int totalRutas = rutas.Count;

// Distancia media
double distanciaMedia = rutas.Average(r => r.DistanciaKm);

// Distancia total
double distanciaTotal = rutas.Sum(r => r.DistanciaKm);

// Ruta más larga
Ruta rutaMasLarga = rutas.OrderByDescending(r => r.DistanciaKm).First();

// Ruta más corta
Ruta rutaMasCorta = rutas.OrderBy(r => r.DistanciaKm).First();

// Mayor desnivel
Ruta mayorDesnivel = rutas.OrderByDescending(r => r.Desnivel).First();

// Menor desnivel
Ruta menorDesnivel = rutas.OrderBy(r => r.Desnivel).First();

// Rutas por dificultad
int faciles = rutas.Count(r => r.DificultadRuta == Dificultad.FACIL);
int medias = rutas.Count(r => r.DificultadRuta == Dificultad.MEDIA);
int dificiles = rutas.Count(r => r.DificultadRuta == Dificultad.DIFICIL);
```

### Ejemplo 5: Agrupar Rutas

```csharp
// Agrupar por provincia
var rutasPorProvincia = App.lRutas.GroupBy(r => r.Provincia);

foreach (var grupo in rutasPorProvincia)
{
    Debug.WriteLine($"Provincia: {grupo.Key}");
    foreach (var ruta in grupo)
    {
        Debug.WriteLine($"  - {ruta.Nombre}");
    }
}

// Agrupar por dificultad
var rutasPorDificultad = App.lRutas.GroupBy(r => r.DificultadRuta);

// Obtener provincias únicas
var provincias = App.lRutas.Select(r => r.Provincia).Distinct().OrderBy(p => p);
```

### Ejemplo 6: Validación de Datos

```csharp
private async Task<bool> ValidarRuta(string id, string nombre, string distancia)
{
    // Validar ID no vacío
    if (string.IsNullOrWhiteSpace(id))
    {
        await DisplayAlert("Error", "El ID es obligatorio", "OK");
        return false;
    }
    
    // Validar ID único
    if (App.lRutas.Any(r => r.Id.Equals(id, StringComparison.OrdinalIgnoreCase)))
    {
        await DisplayAlert("Error", "Ya existe una ruta con ese ID", "OK");
        return false;
    }
    
    // Validar nombre no vacío
    if (string.IsNullOrWhiteSpace(nombre))
    {
        await DisplayAlert("Error", "El nombre es obligatorio", "OK");
        return false;
    }
    
    // Validar distancia numérica y positiva
    if (!double.TryParse(distancia, out double dist) || dist <= 0)
    {
        await DisplayAlert("Error", "La distancia debe ser un número mayor que 0", "OK");
        return false;
    }
    
    return true;
}
```

### Ejemplo 7: Navegación con Parámetros

```csharp
// Desde la página de lista
private async void OnRutaSeleccionada(object sender, SelectionChangedEventArgs e)
{
    if (e.CurrentSelection.FirstOrDefault() is Ruta ruta)
    {
        await Shell.Current.GoToAsync($"DetalleRuta?Id={ruta.Id}");
    }
}

// En la página de detalle
[QueryProperty(nameof(RutaId), "Id")]
public partial class DetalleRuta : ContentPage
{
    private string _rutaId;
    
    public string RutaId
    {
        get => _rutaId;
        set
        {
            _rutaId = value;
            CargarDetalles();
        }
    }
    
    private void CargarDetalles()
    {
        var ruta = App.lRutas.FirstOrDefault(r => r.Id == RutaId);
        if (ruta != null)
        {
            NombreLabel.Text = ruta.Nombre;
            ProvinciaLabel.Text = ruta.Provincia;
            // ... más campos
        }
    }
}
```

## 📊 Datos de Ejemplo Precargados

Las 6 rutas que vienen precargadas:

```csharp
public void Rellenar()
{
    this.Add(new Ruta("R001", "Senda del Bosque Encantado",   
        Dificultad.FACIL,   6.5,  250,   "Ávila",      true,  
        new DateTime(2020, 3, 1),  
        new List<string> { "Bosque", "Familiar", "Río" }));
        
    this.Add(new Ruta("R002", "Ascenso al Pico Alto",         
        Dificultad.DIFICIL, 14.2, 1200,  "León",       false, 
        new DateTime(2018, 7, 15), 
        new List<string> { "Montaña", "Cumbre", "Panorámica" }));
        
    this.Add(new Ruta("R003", "Ruta de las Cascadas",         
        Dificultad.MEDIA,    9.8,  600,  "Burgos",     true,  
        new DateTime(2019, 5, 10), 
        new List<string> { "Cascadas", "Río", "Sombras" }));
        
    this.Add(new Ruta("R004", "Sendero del Valle Escondido",  
        Dificultad.FACIL,    4.3,  150,  "Salamanca",  false, 
        new DateTime(2021, 9, 20), 
        new List<string> { "Valle", "Familiar", "Primavera" }));
        
    this.Add(new Ruta("R005", "Cresterío de la Sierra Norte", 
        Dificultad.DIFICIL, 18.0, 1500,  "Segovia",    true,  
        new DateTime(2017, 10, 5), 
        new List<string> { "Larga distancia", "Técnica", "Cresterío" }));
        
    this.Add(new Ruta("R006", "Vía Verde del Río Tranquilo",  
        Dificultad.MEDIA,   12.0,  300,  "Valladolid", false, 
        new DateTime(2022, 4, 12), 
        new List<string> { "Río", "Llano", "Bici" }));
}
```

## 🎨 Estilos Visuales

### Paleta de Colores

```
Primary (Verde Oscuro):   #2E7D32 ████████
Secondary (Verde Claro):  #81C784 ████████
Tertiary (Verde Muy Osc): #1B5E20 ████████
White:                    #FFFFFF ████████
Gray100:                  #E0E0E0 ████████
Gray200:                  #C2C2C2 ████████
```

### Tipografía

- **Títulos grandes**: 24px, Bold
- **Títulos medianos**: 18px, Bold
- **Subtítulos**: 16px, Normal
- **Texto normal**: 14px, Normal
- **Texto pequeño**: 12px, Normal

### Espaciado

- **Margin entre elementos**: 10px
- **Padding en Frames**: 15-20px
- **Corner Radius en Frames**: 10px
- **Corner Radius en Buttons**: 10px

## 🔄 Flujos de Usuario

### Flujo: Crear una Nueva Ruta

```
1. Usuario abre la app
   └─> Pantalla de Bienvenida

2. Usuario toca pestaña "Crear Ruta"
   └─> Formulario de creación

3. Usuario completa todos los campos
   ├─> ID: R007
   ├─> Nombre: Camino del Pastor
   ├─> Dificultad: MEDIA
   ├─> Distancia: 8.5
   ├─> Desnivel: 450
   ├─> Provincia: León
   ├─> Circular: Sí
   ├─> Fecha: 15/03/2024
   └─> Etiquetas: Montaña, Pastos

4. Usuario toca "Crear Ruta"
   └─> Sistema valida datos
       ├─> [Válidos] ─> Crea ruta ─> Muestra confirmación
       └─> [Inválidos] ─> Muestra error ─> Vuelve al formulario

5. Usuario ve confirmación "Ruta creada correctamente"
   └─> Formulario se limpia
```

### Flujo: Ver Detalle de Ruta

```
1. Usuario toca pestaña "Ver Rutas"
   └─> Lista de todas las rutas

2. Usuario toca una ruta específica
   └─> Navegación a página de detalle

3. Sistema muestra toda la información
   ├─> Nombre
   ├─> ID
   ├─> Dificultad
   ├─> Distancia
   ├─> Desnivel
   ├─> Provincia
   ├─> Tipo (Circular/Lineal)
   ├─> Fecha de apertura
   └─> Etiquetas

4. Usuario puede volver a la lista
   └─> Botón "Atrás"
```

### Flujo: Modificar Dificultad

```
1. Usuario toca "Modificar Ruta" → "Modificar Dificultad"
   └─> Pantalla de modificación

2. Usuario selecciona ruta del Picker
   └─> Sistema muestra dificultad actual

3. Usuario selecciona nueva dificultad
   └─> Selecciona del Picker (FACIL/MEDIA/DIFICIL)

4. Usuario toca "Modificar Dificultad"
   └─> Sistema muestra confirmación

5. Usuario confirma
   └─> Dificultad actualizada
   └─> Mensaje de éxito
```

## 🎯 Casos de Uso Comunes

### Caso de Uso 1: Planificar Salida Familiar

**Objetivo**: Encontrar una ruta fácil cerca de Salamanca

```
1. Ir a "Ver Rutas" → "Ver Rutas Provincia"
2. Seleccionar "Salamanca"
3. Ver: Sendero del Valle Escondido
   - FACIL
   - 4.3 km
   - 150 m desnivel
   - Etiquetas: Valle, Familiar, Primavera
4. Tocar para ver más detalles
5. ¡Perfecta para la familia!
```

### Caso de Uso 2: Reto de Montaña

**Objetivo**: Encontrar la ruta más difícil con más desnivel

```
1. Ir a "Ver Rutas" → "Ver Estadísticas Rutas"
2. Ver "Mayor Desnivel":
   - Cresterío de la Sierra Norte
   - 1500 m desnivel
   - 18.0 km
   - Segovia
3. Tocar el nombre para ver detalles completos
4. Ver etiquetas: Larga distancia, Técnica, Cresterío
5. ¡Reto aceptado!
```

### Caso de Uso 3: Documentar Nueva Ruta

**Objetivo**: Añadir una ruta que acabo de descubrir

```
1. Ir a "Crear Ruta"
2. Introducir datos:
   - ID: R007
   - Nombre: Camino Secreto del Río
   - Dificultad: MEDIA
   - Distancia: 11.2 km
   - Desnivel: 380 m
   - Provincia: Ávila
   - Circular: No
   - Fecha: Hoy
   - Etiquetas: Río, Bosque, Puentes
3. Guardar
4. ¡Ruta documentada!
```

## 📚 Recursos Adicionales

Para más información:
- [Guía de Usuario](User-Guide) - Cómo usar la aplicación
- [Documentación Técnica](Technical-Documentation) - Detalles de implementación
- [API Reference](API-Reference) - Documentación de clases y métodos

---

**Nota**: Las capturas de pantalla reales pueden variar según la plataforma (Android, iOS, Windows, macOS) y la configuración del dispositivo.
