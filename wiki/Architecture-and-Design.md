# 🏗️ Arquitectura y Diseño

Esta página describe la arquitectura y el diseño de la aplicación EmpresaTurismo.

## 📐 Arquitectura General

EmpresaTurismo sigue una arquitectura **MVVM (Model-View-ViewModel)** simplificada, característica de aplicaciones .NET MAUI.

### Diagrama de Arquitectura

```
┌─────────────────────────────────────────┐
│           Presentación (UI)             │
│  ┌────────────────────────────────────┐ │
│  │   XAML Views (ContentPages)        │ │
│  │  - MainPage                        │ │
│  │  - CrearRuta                       │ │
│  │  - MostrarRutas                    │ │
│  │  - DetalleRuta                     │ │
│  │  - ModificarDificultadRuta         │ │
│  │  - AnadirEliminarEtiquetas         │ │
│  │  - EliminarRuta                    │ │
│  │  - MostrarRutasEstadisticas        │ │
│  │  - MostrarRutasProvincias          │ │
│  │  - MostrarRutasEtiquetas           │ │
│  │  - VerRuta                         │ │
│  └────────────────────────────────────┘ │
└─────────────────────────────────────────┘
                    ↕
┌─────────────────────────────────────────┐
│         Lógica de Negocio               │
│  ┌────────────────────────────────────┐ │
│  │   Code-Behind (.cs files)          │ │
│  │  - Event Handlers                  │ │
│  │  - Business Logic                  │ │
│  │  - Data Validation                 │ │
│  └────────────────────────────────────┘ │
└─────────────────────────────────────────┘
                    ↕
┌─────────────────────────────────────────┐
│         Capa de Datos                   │
│  ┌────────────────────────────────────┐ │
│  │   Modelo de Datos                  │ │
│  │  - Ruta (Clase)                    │ │
│  │  - Dificultad (Enum)               │ │
│  │                                    │ │
│  │   Almacenamiento                   │ │
│  │  - DatosMock (ObservableCollection)│ │
│  └────────────────────────────────────┘ │
└─────────────────────────────────────────┘
                    ↕
┌─────────────────────────────────────────┐
│      Framework y Plataforma             │
│  ┌────────────────────────────────────┐ │
│  │   .NET MAUI                        │ │
│  │  - Android                         │ │
│  │  - iOS                             │ │
│  │  - macOS                           │ │
│  │  - Windows                         │ │
│  └────────────────────────────────────┘ │
└─────────────────────────────────────────┘
```

## 🧩 Componentes Principales

### 1. Capa de Presentación (Views)

#### AppShell.xaml
- **Propósito**: Define la estructura de navegación de la aplicación
- **Responsabilidades**:
  - Configuración de pestañas (TabBar)
  - Rutas de navegación
  - Organización de ShellContent
- **Patrón**: Shell Navigation

#### ContentPages (Vistas)
Cada página XAML representa una pantalla de la aplicación:

| Vista | Propósito |
|-------|-----------|
| `MainPage` | Pantalla de bienvenida |
| `CrearRuta` | Formulario de creación de rutas |
| `MostrarRutas` | Listado completo de rutas |
| `DetalleRuta` | Detalle de una ruta específica |
| `ModificarDificultadRuta` | Cambiar dificultad de una ruta |
| `AnadirEliminarEtiquetas` | Gestión de etiquetas |
| `EliminarRuta` | Eliminar rutas |
| `MostrarRutasEstadisticas` | Estadísticas agregadas |
| `MostrarRutasProvincias` | Filtro por provincia |
| `MostrarRutasEtiquetas` | Filtro por etiquetas |
| `VerRuta` | Vista detallada de ruta |

### 2. Capa de Lógica de Negocio

#### Code-Behind (.cs files)
- **Propósito**: Implementar la lógica de cada vista
- **Responsabilidades**:
  - Manejo de eventos de UI
  - Validación de datos
  - Navegación entre páginas
  - Actualización de la UI
  - Comunicación con la capa de datos

**Patrón común**:
```csharp
public partial class CrearRuta : ContentPage
{
    DatosMock datosMock = App.lRutas;  // Acceso a datos
    
    public CrearRuta()
    {
        InitializeComponent();  // Inicialización
    }
    
    private async void NuevaRuta(object sender, EventArgs e)
    {
        // Validación
        // Procesamiento
        // Actualización de datos
        // Feedback al usuario
    }
}
```

### 3. Capa de Modelo de Datos

#### Clase Ruta
- **Propósito**: Representar una ruta de senderismo
- **Patrón**: Plain Old CLR Object (POCO)
- **Propiedades**:
  - Id: Identificador único
  - Nombre: Nombre descriptivo
  - DificultadRuta: Nivel de dificultad
  - DistanciaKm: Longitud de la ruta
  - Desnivel: Desnivel acumulado
  - Provincia: Ubicación
  - Circular: Tipo de ruta
  - FechaApertura: Fecha de creación
  - Etiquetas: Palabras clave

#### Enum Dificultad
- **Propósito**: Definir niveles de dificultad
- **Valores**: FACIL, MEDIA, DIFICIL
- **Tipo**: Enumeración

### 4. Capa de Almacenamiento

#### DatosMock
- **Propósito**: Almacenamiento en memoria de rutas
- **Tipo**: `ObservableCollection<Ruta>`
- **Características**:
  - Notificaciones automáticas de cambios
  - Integración con data binding de XAML
  - Datos precargados (6 rutas de ejemplo)

## 🔄 Flujo de Datos

### Flujo de Creación de Ruta

```
Usuario → UI (CrearRuta.xaml)
           ↓
        Event Handler (NuevaRuta)
           ↓
        Validación de Datos
           ↓
        Creación de objeto Ruta
           ↓
        DatosMock.Add(nuevaRuta)
           ↓
        Notificación de cambio (ObservableCollection)
           ↓
        Actualización de UI automática
           ↓
        DisplayAlert (Confirmación)
```

### Flujo de Visualización de Rutas

```
Usuario → UI (MostrarRutas.xaml)
           ↓
        OnAppearing()
           ↓
        Binding a DatosMock (App.lRutas)
           ↓
        CollectionView renderiza lista
           ↓
        Usuario selecciona ruta
           ↓
        Navegación a DetalleRuta
           ↓
        Paso de parámetros (QueryProperty)
           ↓
        Renderizado de detalles
```

## 🎨 Patrones de Diseño Utilizados

### 1. Singleton
- **Uso**: `App.lRutas` es una instancia única compartida
- **Propósito**: Garantizar un único almacén de datos en toda la aplicación
- **Implementación**:
```csharp
public partial class App : Application
{
    public static DatosMock lRutas { get; set; }
    
    public App()
    {
        InitializeComponent();
        lRutas = new DatosMock();
        lRutas.Rellenar();
        MainPage = new AppShell();
    }
}
```

### 2. Observer (Observable Collection)
- **Uso**: `DatosMock` extiende `ObservableCollection<Ruta>`
- **Propósito**: Notificar cambios automáticamente a la UI
- **Beneficio**: Sincronización automática entre datos y vista

### 3. Navigation Shell
- **Uso**: `AppShell` para navegación
- **Propósito**: Navegación declarativa y jerárquica
- **Características**:
  - Navegación basada en pestañas
  - Rutas URI
  - Flyout menu capability

### 4. Data Binding
- **Uso**: Conexión entre XAML y datos
- **Propósito**: Separación de UI y lógica
- **Ejemplo**:
```xaml
<CollectionView ItemsSource="{Binding Source={x:Static local:App.lRutas}}">
```

### 5. Repository Pattern (Simplificado)
- **Uso**: `DatosMock` actúa como repositorio
- **Propósito**: Abstracción del almacenamiento de datos
- **Métodos**: Add, Remove, Query (LINQ)

## 🏛️ Principios de Diseño

### SOLID Principles

#### Single Responsibility Principle (SRP)
- Cada página tiene una responsabilidad única
- `CrearRuta`: solo creación
- `EliminarRuta`: solo eliminación
- `MostrarRutasEstadisticas`: solo estadísticas

#### Open/Closed Principle
- Las clases están abiertas a extensión (herencia de ContentPage)
- Cerradas a modificación (funcionalidad base no se cambia)

#### Dependency Inversion
- Las páginas dependen de la abstracción (`DatosMock` como colección)
- No dependen de implementaciones concretas de almacenamiento

### DRY (Don't Repeat Yourself)
- Uso de `App.lRutas` centralizado
- Métodos reutilizables como validación
- Componentes XAML reutilizables

## 📱 Navegación

### Tipos de Navegación

#### 1. Navegación por Pestañas (TabBar)
- Navegación principal entre secciones
- Implementada en `AppShell.xaml`
- 5 pestañas principales

#### 2. Navegación Jerárquica
- Push/Pop de páginas en el stack
- Ejemplo: Lista de rutas → Detalle de ruta
- Uso de `Shell.Current.GoToAsync()`

#### 3. Navegación con Parámetros
```csharp
// Enviar
await Shell.Current.GoToAsync($"DetalleRuta?Id={ruta.Id}");

// Recibir
[QueryProperty(nameof(RutaId), "Id")]
public string RutaId { get; set; }
```

## 🎯 Decisiones de Arquitectura

### ¿Por qué ObservableCollection?
- **Razón**: Actualización automática de UI
- **Beneficio**: Menos código boilerplate
- **Trade-off**: Solo persistencia en memoria

### ¿Por qué Code-Behind en lugar de ViewModels?
- **Razón**: Simplicidad para una aplicación académica
- **Beneficio**: Menos archivos, más directo
- **Trade-off**: Menor testabilidad, acoplamiento UI-lógica

### ¿Por qué Shell Navigation?
- **Razón**: Patrón moderno de .NET MAUI
- **Beneficio**: Navegación declarativa, URLs, deep linking
- **Características**: Flyout, tabs, routes automáticas

### ¿Por qué Datos en Memoria?
- **Razón**: Prototipo/práctica académica
- **Beneficio**: Sin dependencias externas, simple
- **Limitación**: Datos no persisten entre sesiones
- **Evolución futura**: Podría cambiarse a SQLite, API REST, etc.

## 🔮 Extensibilidad

### Posibles Mejoras Arquitecturales

1. **MVVM Completo**
   - Añadir ViewModels
   - Usar Community Toolkit MVVM
   - Mejorar testabilidad

2. **Persistencia Real**
   - Implementar SQLite local
   - Añadir sincronización con API
   - Cache y offline support

3. **Servicios**
   - Extraer lógica a servicios
   - Dependency Injection
   - Mejor separación de responsabilidades

4. **Validación**
   - FluentValidation
   - Validación más robusta
   - Mensajes de error mejorados

## 📊 Diagrama de Clases

```
┌─────────────────────┐
│    Application      │
│       (App)         │
├─────────────────────┤
│ + lRutas: DatosMock│
└──────────┬──────────┘
           │ creates
           ↓
┌─────────────────────┐
│    DatosMock        │
├─────────────────────┤
│ Inherits from:      │
│ ObservableCollection│
│ <Ruta>              │
├─────────────────────┤
│ + Rellenar(): void  │
│ + MostrarRutas()    │
└──────────┬──────────┘
           │ contains
           ↓
┌─────────────────────┐
│       Ruta          │
├─────────────────────┤
│ + Id: string        │
│ + Nombre: string    │
│ + DificultadRuta    │
│ + DistanciaKm       │
│ + Desnivel          │
│ + Provincia: string │
│ + Circular: bool    │
│ + FechaApertura     │
│ + Etiquetas: List   │
└─────────────────────┘
           ↑
           │ uses
┌──────────┴──────────┐
│    Dificultad       │
│      (enum)         │
├─────────────────────┤
│ FACIL               │
│ MEDIA               │
│ DIFICIL             │
└─────────────────────┘
```

## 🔗 Referencias

- [.NET MAUI Documentation](https://learn.microsoft.com/en-us/dotnet/maui/)
- [Shell Navigation](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation)
- [Data Binding](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/data-binding/)
- [MVVM Pattern](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm)
