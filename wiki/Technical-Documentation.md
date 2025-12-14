# 🔧 Documentación Técnica

Esta página proporciona detalles técnicos de implementación de EmpresaTurismo.

## 🛠️ Stack Tecnológico

### Framework Principal
- **.NET 9.0**: Última versión del framework .NET
- **.NET MAUI**: Multi-platform App UI para aplicaciones multiplataforma
- **C# 12**: Lenguaje de programación

### UI
- **XAML**: Lenguaje de marcado para definir interfaces
- **Data Binding**: Sincronización automática entre datos y UI
- **Shell Navigation**: Sistema moderno de navegación

### Plataformas Soportadas
- 📱 **Android** (API 21+)
- 🍎 **iOS** (iOS 11+)
- 💻 **Windows** (Windows 10 1809+)
- 🖥️ **macOS** (macOS 11+)

## 📁 Estructura de Archivos

```
EmpresaTurismo/
│
├── App.xaml                          # Configuración global de la app
├── App.xaml.cs                       # Lógica de inicialización
├── AppShell.xaml                     # Definición de navegación
├── AppShell.xaml.cs                  # Lógica de navegación
├── MauiProgram.cs                    # Punto de entrada y configuración
├── GlobalXmlns.cs                    # Namespaces XAML globales
│
├── Ruta.cs                           # Modelo de datos: Clase Ruta y Enum Dificultad
├── DatosMock.cs                      # Almacenamiento en memoria
│
├── MainPage.xaml                     # Vista de bienvenida
├── MainPage.xaml.cs                  # Lógica de página principal
│
├── CrearRuta.xaml                    # Vista de creación
├── CrearRuta.xaml.cs                 # Lógica de creación
│
├── MostrarRutas.xaml                 # Vista de listado
├── MostrarRutas.xaml.cs              # Lógica de listado
│
├── DetalleRuta.xaml                  # Vista de detalle
├── DetalleRuta.xaml.cs               # Lógica de detalle
│
├── ModificarDificultadRuta.xaml      # Vista de modificación de dificultad
├── ModificarDificultadRuta.xaml.cs   # Lógica de modificación
│
├── ModificarRuta.xaml                # Vista de modificación general
├── ModificarRuta.xaml.cs             # Lógica de modificación
│
├── AnadirEliminarEtiquetas.xaml      # Vista de gestión de etiquetas
├── AnadirEliminarEtiquetas.xaml.cs   # Lógica de etiquetas
│
├── EliminarRuta.xaml                 # Vista de eliminación
├── EliminarRuta.xaml.cs              # Lógica de eliminación
│
├── MostrarRutasEstadisticas.xaml     # Vista de estadísticas
├── MostrarRutasEstadisticas.xaml.cs  # Lógica de estadísticas
│
├── MostrarRutasProvincias.xaml       # Vista de filtro por provincia
├── MostrarRutasProvincias.xaml.cs    # Lógica de filtro
│
├── MostrarRutasEtiquetas.xaml        # Vista de filtro por etiquetas
├── MostrarRutasEtiquetas.xaml.cs     # Lógica de búsqueda
│
├── VerRuta.xaml                      # Vista alternativa de detalle
├── VerRuta.xaml.cs                   # Lógica de vista
│
├── Platforms/                        # Código específico de plataforma
│   ├── Android/                      # Configuración Android
│   ├── iOS/                          # Configuración iOS
│   ├── MacCatalyst/                  # Configuración macOS
│   └── Windows/                      # Configuración Windows
│
├── Properties/                       # Propiedades del proyecto
│   └── launchSettings.json           # Configuración de lanzamiento
│
└── Resources/                        # Recursos de la aplicación
    ├── AppIcon/                      # Iconos de la app
    ├── Fonts/                        # Fuentes personalizadas
    ├── Images/                       # Imágenes y recursos gráficos
    │   ├── rutasenderismo.png
    │   ├── inicio.png
    │   ├── crear.png
    │   ├── mostrar.png
    │   ├── modificar.png
    │   └── eliminar.png
    ├── Raw/                          # Archivos sin procesar
    ├── Splash/                       # Pantalla de splash
    └── Styles/                       # Estilos XAML
        ├── Colors.xaml               # Paleta de colores
        └── Styles.xaml               # Estilos globales
```

## 🔧 MauiProgram.cs

Punto de entrada de la aplicación y configuración.

```csharp
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}
```

### Configuraciones Disponibles

- **UseMauiApp<App>()**: Establece la clase App como punto de entrada
- **ConfigureFonts**: Registra fuentes personalizadas
- **ConfigureEssentials**: Servicios esenciales (geolocalización, almacenamiento, etc.)
- **ConfigureLifecycleEvents**: Eventos del ciclo de vida de la app

## 📊 Gestión de Datos

### ObservableCollection

**Ventajas**:
- ✅ Notificaciones automáticas de cambios
- ✅ Integración perfecta con data binding
- ✅ Actualización automática de UI
- ✅ Sin código adicional para sincronización

**Implementación**:
```csharp
public class DatosMock : ObservableCollection<Ruta>
{
    // La colección notifica automáticamente los cambios
}
```

### Data Binding en XAML

**Binding estático a singleton**:
```xml
<CollectionView ItemsSource="{Binding Source={x:Static local:App.lRutas}}">
```

**Binding a propiedades**:
```xml
<Label Text="{Binding Nombre}" />
<Label Text="{Binding DistanciaKm, StringFormat='{0} km'}" />
```

## 🎨 Patrones de Diseño UI

### Layouts Utilizados

#### Grid
Para diseños complejos con filas y columnas:
```xml
<Grid RowDefinitions="Auto,*" ColumnDefinitions="*,*">
    <Label Grid.Row="0" Grid.Column="0" Text="Campo 1" />
    <Entry Grid.Row="0" Grid.Column="1" />
</Grid>
```

#### StackLayout / VerticalStackLayout
Para apilar elementos verticalmente:
```xml
<VerticalStackLayout Spacing="10">
    <Label Text="Título" />
    <Entry />
    <Button Text="Guardar" />
</VerticalStackLayout>
```

#### ScrollView
Para contenido que puede exceder el tamaño de pantalla:
```xml
<ScrollView>
    <VerticalStackLayout>
        <!-- Contenido largo -->
    </VerticalStackLayout>
</ScrollView>
```

### Estilos

**Estilos globales** (Styles.xaml):
```xml
<Style TargetType="Button">
    <Setter Property="BackgroundColor" Value="#2E7D32" />
    <Setter Property="TextColor" Value="White" />
    <Setter Property="CornerRadius" Value="10" />
</Style>
```

**Estilos inline**:
```xml
<Label Text="Título" 
       FontSize="24" 
       FontAttributes="Bold"
       TextColor="#2E7D32" />
```

## 🔄 Navegación

### Shell Navigation

**Navegación simple**:
```csharp
await Shell.Current.GoToAsync("NombreRuta");
```

**Navegación con parámetros**:
```csharp
await Shell.Current.GoToAsync($"DetalleRuta?Id={rutaId}");
```

**Navegación hacia atrás**:
```csharp
await Shell.Current.GoToAsync("..");
```

### QueryProperty

**Definir receptor**:
```csharp
[QueryProperty(nameof(RutaId), "Id")]
public string RutaId 
{ 
    get => _rutaId;
    set
    {
        _rutaId = value;
        CargarDetalles();
    }
}
```

## 🎯 Validación de Datos

### Validaciones Implementadas

#### Campos Obligatorios
```csharp
if (string.IsNullOrWhiteSpace(NombreEntry.Text))
{
    await DisplayAlert("Error", "El nombre es obligatorio", "OK");
    return;
}
```

#### Validación Numérica
```csharp
if (!double.TryParse(DistanciaEntry.Text, out double distancia))
{
    await DisplayAlert("Error", "Distancia no válida", "OK");
    return;
}
```

#### Validación de Enum
```csharp
if (!Enum.TryParse<Dificultad>(valor, out Dificultad dificultad))
{
    await DisplayAlert("Error", "Dificultad no válida", "OK");
    return;
}
```

#### Unicidad
```csharp
if (App.lRutas.Any(r => r.Id == id))
{
    await DisplayAlert("Error", "ID duplicado", "OK");
    return;
}
```

## 📱 Ciclo de Vida de Páginas

### Métodos Principales

#### OnAppearing()
```csharp
protected override void OnAppearing()
{
    base.OnAppearing();
    // Se ejecuta cuando la página se muestra
    CargarDatos();
}
```

#### OnDisappearing()
```csharp
protected override void OnDisappearing()
{
    base.OnDisappearing();
    // Se ejecuta cuando la página se oculta
    GuardarEstado();
}
```

### Ciclo de Vida de la Aplicación

```csharp
public partial class App : Application
{
    protected override void OnStart()
    {
        // App iniciada
    }

    protected override void OnSleep()
    {
        // App en segundo plano
    }

    protected override void OnResume()
    {
        // App vuelve al primer plano
    }
}
```

## 🔍 LINQ y Consultas

### Filtros Comunes

```csharp
// Filtrar
var faciles = App.lRutas.Where(r => r.DificultadRuta == Dificultad.FACIL);

// Ordenar
var ordenadas = App.lRutas.OrderBy(r => r.DistanciaKm);
var descendente = App.lRutas.OrderByDescending(r => r.Desnivel);

// Buscar
var ruta = App.lRutas.FirstOrDefault(r => r.Id == "R001");

// Contar
int count = App.lRutas.Count(r => r.Provincia == "León");

// Agrupar
var grupos = App.lRutas.GroupBy(r => r.Provincia);

// Proyectar
var nombres = App.lRutas.Select(r => r.Nombre);

// Existencia
bool existe = App.lRutas.Any(r => r.Etiquetas.Contains("Montaña"));
```

### Estadísticas con LINQ

```csharp
// Promedio
double mediaDistancia = App.lRutas.Average(r => r.DistanciaKm);

// Suma
double totalKm = App.lRutas.Sum(r => r.DistanciaKm);

// Máximo
double maxDesnivel = App.lRutas.Max(r => r.Desnivel);

// Mínimo
double minDistancia = App.lRutas.Min(r => r.DistanciaKm);

// Elemento con valor máximo
var rutaMasLarga = App.lRutas.OrderByDescending(r => r.DistanciaKm).First();
```

## 🎨 Temas y Colores

### Paleta de Colores Principal

En `Resources/Styles/Colors.xaml`:

```xml
<Color x:Key="Primary">#2E7D32</Color>         <!-- Verde principal -->
<Color x:Key="Secondary">#81C784</Color>       <!-- Verde claro -->
<Color x:Key="Tertiary">#1B5E20</Color>        <!-- Verde oscuro -->
<Color x:Key="White">White</Color>
<Color x:Key="Black">Black</Color>
<Color x:Key="Gray100">#E0E0E0</Color>
<Color x:Key="Gray200">#C2C2C2</Color>
<Color x:Key="Gray300">#A3A3A3</Color>
```

### Uso de Colores

```xml
<Button BackgroundColor="{StaticResource Primary}" 
        TextColor="{StaticResource White}" />
```

## 🖼️ Recursos e Imágenes

### Iconos de Navegación

| Icono | Archivo | Uso |
|-------|---------|-----|
| 🏠 | inicio.png | Pestaña de inicio |
| ➕ | crear.png | Pestaña de creación |
| 👁️ | mostrar.png | Pestaña de visualización |
| ✏️ | modificar.png | Pestaña de modificación |
| 🗑️ | eliminar.png | Pestaña de eliminación |

### Imagen de Fondo

- **rutasenderismo.png**: Imagen de fondo en MainPage

### Gestión de Recursos

Los recursos se colocan en `Resources/Images/` y se referencian por nombre:

```xml
<Image Source="rutasenderismo.png" />
<Tab Icon="inicio.png" />
```

## ⚡ Rendimiento

### Optimizaciones Implementadas

1. **ObservableCollection**: Notificaciones eficientes de cambios
2. **Data Binding**: Actualización selectiva de UI
3. **Virtualización**: CollectionView virtualiza elementos fuera de pantalla
4. **Carga Lazy**: Páginas se crean solo cuando se navega a ellas

### Mejores Prácticas

- ✅ Usar `async/await` para operaciones que podrían bloquear UI
- ✅ Evitar lógica pesada en event handlers
- ✅ Usar CollectionView en lugar de ListView para listas largas
- ✅ Minimizar binding complejos en XAML

## 🐛 Depuración

### Debug.WriteLine

```csharp
using System.Diagnostics;

Debug.WriteLine($"Ruta creada: {ruta.Nombre}");
```

### Breakpoints

Establecer puntos de interrupción en Visual Studio:
- F9 para toggle breakpoint
- F5 para ejecutar con depuración
- F10 para paso a paso
- F11 para entrar en métodos

### Logging

```csharp
try
{
    // Código
}
catch (Exception ex)
{
    Debug.WriteLine($"Error: {ex.Message}");
    Debug.WriteLine($"Stack: {ex.StackTrace}");
    await DisplayAlert("Error", ex.Message, "OK");
}
```

## 🔒 Consideraciones de Seguridad

### Datos Actuales
- ⚠️ Los datos están solo en memoria
- ⚠️ No hay autenticación
- ⚠️ No hay validación exhaustiva de entrada

### Recomendaciones para Producción
- 🔐 Implementar autenticación y autorización
- 🔐 Validar y sanitizar todas las entradas
- 🔐 Usar HTTPS para comunicaciones
- 🔐 Encriptar datos sensibles
- 🔐 Implementar rate limiting

## 📦 Dependencias

### Paquetes NuGet Principales

```xml
<ItemGroup>
    <PackageReference Include="Microsoft.Maui.Controls" Version="9.0.0" />
    <PackageReference Include="Microsoft.Maui.Controls.Compatibility" Version="9.0.0" />
</ItemGroup>
```

### Target Frameworks

```xml
<TargetFrameworks>
    net9.0-android;
    net9.0-ios;
    net9.0-maccatalyst;
    net9.0-windows10.0.19041.0
</TargetFrameworks>
```

## 🧪 Testing

### Estado Actual
- ❌ No hay tests unitarios implementados
- ❌ No hay tests de integración
- ❌ No hay tests de UI

### Recomendaciones
- Usar xUnit o NUnit para tests unitarios
- Usar Moq para mocking
- Usar Appium para tests de UI
- Implementar CI/CD con tests automáticos

## 🚀 Compilación y Despliegue

### Compilar para Android

```bash
dotnet build -f net9.0-android -c Release
```

### Compilar para iOS

```bash
dotnet build -f net9.0-ios -c Release
```

### Compilar para Windows

```bash
dotnet build -f net9.0-windows10.0.19041.0 -c Release
```

### Publicar para Android

```bash
dotnet publish -f net9.0-android -c Release -p:AndroidKeyStore=true -p:AndroidSigningKeyStore=myapp.keystore
```

## 📚 Referencias Técnicas

- [.NET MAUI Documentation](https://learn.microsoft.com/en-us/dotnet/maui/)
- [C# Programming Guide](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [XAML Overview](https://learn.microsoft.com/en-us/dotnet/maui/xaml/)
- [LINQ Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)
- [ObservableCollection](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1)
