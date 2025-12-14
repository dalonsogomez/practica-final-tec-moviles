# 🥾 EmpresaTurismo - Gestión de Rutas de Senderismo

Aplicación móvil desarrollada con **.NET MAUI** para la gestión de rutas de senderismo. Permite crear, visualizar, modificar y eliminar rutas con información detallada.

## 📱 Funcionalidades

- **Crear rutas**: Añadir nuevas rutas con nombre, provincia, dificultad, distancia y etiquetas
- **Ver rutas**: Listado completo de todas las rutas disponibles
- **Detalle de ruta**: Visualización detallada de cada ruta
- **Modificar dificultad**: Cambiar el nivel de dificultad de una ruta
- **Gestionar etiquetas**: Añadir o eliminar etiquetas de las rutas
- **Eliminar rutas**: Borrar rutas del sistema
- **Estadísticas**: Ver estadísticas como ruta más larga, distancia media, etc.
- **Filtrar por provincia**: Ver rutas agrupadas por provincia
- **Filtrar por etiquetas**: Buscar rutas por etiquetas específicas

## 🏗️ Estructura del Proyecto

```
EmpresaTurismo/
├── App.xaml / App.xaml.cs          # Punto de entrada de la aplicación
├── AppShell.xaml / AppShell.xaml.cs # Navegación y pestañas
├── MainPage.xaml / MainPage.xaml.cs # Página principal
├── Ruta.cs                          # Modelo de datos (clase Ruta y enum Dificultad)
├── DatosMock.cs                     # Almacén de datos en memoria
├── CrearRuta.xaml/.cs               # Crear nueva ruta
├── MostrarRutas.xaml/.cs            # Listado de rutas
├── DetalleRuta.xaml/.cs             # Detalle de una ruta
├── ModificarDificultadRuta.xaml/.cs # Modificar dificultad
├── ModificarRuta.xaml/.cs           # Modificar ruta
├── AnadirEliminarEtiquetas.xaml/.cs # Gestión de etiquetas
├── EliminarRuta.xaml/.cs            # Eliminar ruta
├── MostrarRutasEstadisticas.xaml/.cs # Estadísticas
├── MostrarRutasProvincias.xaml/.cs  # Filtrar por provincia
├── MostrarRutasEtiquetas.xaml/.cs   # Filtrar por etiquetas
└── VerRuta.xaml/.cs                 # Ver ruta específica
```

## 🛠️ Tecnologías

- **.NET 9.0**
- **.NET MAUI** (Multi-platform App UI)
- **C#**
- **XAML**

## 📋 Requisitos

- Visual Studio 2022 (17.8+) con carga de trabajo .NET MAUI
- .NET 9.0 SDK
- Para iOS: macOS con Xcode
- Para Android: Android SDK

## 🚀 Cómo ejecutar

1. Clona el repositorio:
   ```bash
   git clone https://github.com/dalonsogomez/practica-final-tec-moviles.git
   ```

2. Abre la solución en Visual Studio:
   ```bash
   cd practica-final-tec-moviles
   open ProyectoFinal_TecMoviles.sln
   ```

3. Selecciona la plataforma de destino (Android, iOS, macOS, Windows)

4. Ejecuta la aplicación (F5 o botón de Play)

## 📚 Modelo de Datos

### Clase `Ruta`
```csharp
public class Ruta
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    public string Provincia { get; set; }
    public Dificultad DificultadRuta { get; set; }
    public double Distancia { get; set; }
    public List<string> Etiquetas { get; set; }
}
```

### Enum `Dificultad`
```csharp
public enum Dificultad
{
    FACIL,
    MEDIA,
    DIFICIL
}
```

## 👨‍🎓 Información Académica

- **Asignatura**: Tecnologías Móviles
- **Universidad**: UPSA
- **Curso**: 4º

## 📄 Licencia

Este proyecto es parte de una práctica académica.
