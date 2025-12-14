# 📥 Guía de Instalación y Configuración

Esta guía te ayudará a instalar y configurar EmpresaTurismo en tu entorno de desarrollo.

## 📋 Requisitos Previos

### Software Necesario

#### 1. Visual Studio 2022 o Superior
- **Versión mínima**: Visual Studio 2022 (17.8+)
- **Ediciones compatibles**: Community, Professional o Enterprise
- **Descarga**: [Visual Studio 2022](https://visualstudio.microsoft.com/es/vs/)

#### 2. Carga de Trabajo de .NET MAUI
Durante la instalación de Visual Studio, asegúrate de seleccionar:
- ✅ Desarrollo de .NET Multi-platform App UI

#### 3. .NET SDK
- **Versión**: .NET 9.0 SDK o superior
- **Descarga**: [.NET 9.0](https://dotnet.microsoft.com/download/dotnet/9.0)

### Requisitos Específicos por Plataforma

#### Para Desarrollo en Android
- Android SDK (se instala automáticamente con Visual Studio)
- Emulador de Android o dispositivo físico
- Versión mínima de Android: API 21 (Android 5.0)
- Versión objetivo: API 34 (Android 14)

#### Para Desarrollo en iOS
- macOS con Xcode instalado
- Xcode 15 o superior
- Cuenta de desarrollador de Apple (para dispositivos físicos)

#### Para Desarrollo en Windows
- Windows 10 versión 1809 o superior
- Windows 11 recomendado
- Windows App SDK

#### Para Desarrollo en macOS
- macOS 11 (Big Sur) o superior
- Xcode 15 o superior

## 🔧 Instalación

### Paso 1: Clonar el Repositorio

```bash
git clone https://github.com/dalonsogomez/practica-final-tec-moviles.git
cd practica-final-tec-moviles
```

### Paso 2: Abrir la Solución

#### Opción A: Desde la Línea de Comandos
```bash
# Windows
start ProyectoFinal_TecMoviles.sln

# macOS
open ProyectoFinal_TecMoviles.sln

# Linux con Visual Studio Code
code .
```

#### Opción B: Desde Visual Studio
1. Abre Visual Studio 2022
2. Haz clic en "Abrir un proyecto o solución"
3. Navega hasta la carpeta del proyecto
4. Selecciona `ProyectoFinal_TecMoviles.sln`

### Paso 3: Restaurar Paquetes NuGet

Los paquetes NuGet se restaurarán automáticamente al abrir la solución. Si no es así:

```bash
dotnet restore
```

O desde Visual Studio:
- Clic derecho en la solución → "Restaurar paquetes NuGet"

### Paso 4: Seleccionar Plataforma de Destino

En Visual Studio, selecciona la plataforma en la que deseas ejecutar la aplicación:

- **Windows Machine** - Para ejecutar en Windows
- **Android Emulator** - Para ejecutar en emulador Android
- **iOS Simulator** - Para ejecutar en simulador iOS (solo en macOS)

## ▶️ Ejecutar la Aplicación

### Opción 1: Desde Visual Studio

1. Selecciona la plataforma de destino (Android, iOS, Windows, macOS)
2. Presiona **F5** o haz clic en el botón **▶ Ejecutar**

### Opción 2: Desde la Línea de Comandos

#### Para Android
```bash
dotnet build -t:Run -f net9.0-android
```

#### Para iOS
```bash
dotnet build -t:Run -f net9.0-ios
```

#### Para macOS
```bash
dotnet build -t:Run -f net9.0-maccatalyst
```

#### Para Windows
```bash
dotnet build -t:Run -f net9.0-windows10.0.19041.0
```

## 🔍 Verificar la Instalación

Una vez que la aplicación se ejecute correctamente:

1. Deberías ver la pantalla de bienvenida con la imagen de ruta de senderismo
2. Verás 5 pestañas en la parte inferior:
   - 🏠 Inicio
   - ➕ Crear Ruta
   - 👁️ Ver Rutas
   - ✏️ Modificar Ruta
   - 🗑️ Eliminar Ruta

3. La aplicación incluye 6 rutas de ejemplo precargadas

## 🐛 Solución de Problemas

### Error: "Workload 'maui' not found"

```bash
dotnet workload install maui
```

### Error: "Android SDK not found"

1. Abre Visual Studio Installer
2. Modifica tu instalación de Visual Studio
3. Asegúrate de que "Desarrollo para dispositivos móviles con .NET" esté seleccionado
4. Incluye el Android SDK

### Error de compilación en Windows

Si encuentras errores relacionados con Windows SDK:
1. Verifica que tengas Windows 10 SDK instalado (versión 10.0.19041.0 o superior)
2. Instálalo desde Visual Studio Installer si es necesario

### Error en macOS/iOS

Si tienes problemas con iOS:
1. Asegúrate de tener Xcode instalado
2. Ejecuta: `sudo xcode-select --switch /Applications/Xcode.app`
3. Acepta la licencia de Xcode: `sudo xcodebuild -license accept`

## 📦 Estructura del Proyecto

```
practica-final-tec-moviles/
├── ProyectoFinal_TecMoviles.sln    # Solución principal
├── EmpresaTurismo/                  # Proyecto de la aplicación
│   ├── App.xaml                     # Configuración global de la app
│   ├── AppShell.xaml                # Shell de navegación
│   ├── MainPage.xaml                # Página principal
│   ├── Ruta.cs                      # Modelo de datos
│   ├── DatosMock.cs                 # Datos de ejemplo
│   ├── CrearRuta.xaml               # Página para crear rutas
│   ├── MostrarRutas.xaml            # Listado de rutas
│   ├── DetalleRuta.xaml             # Detalle de ruta
│   ├── ModificarDificultadRuta.xaml # Modificar dificultad
│   ├── ModificarRuta.xaml           # Modificar ruta
│   ├── AnadirEliminarEtiquetas.xaml # Gestión de etiquetas
│   ├── EliminarRuta.xaml            # Eliminar ruta
│   ├── MostrarRutasEstadisticas.xaml # Estadísticas
│   ├── MostrarRutasProvincias.xaml  # Filtro por provincia
│   ├── MostrarRutasEtiquetas.xaml   # Filtro por etiquetas
│   ├── VerRuta.xaml                 # Ver ruta específica
│   ├── Platforms/                   # Código específico de plataforma
│   └── Resources/                   # Recursos (imágenes, iconos, etc.)
└── README.md                        # Documentación básica
```

## 🎯 Próximos Pasos

Una vez que hayas instalado y verificado que la aplicación funciona:

1. Lee la [Guía de Usuario](User-Guide) para aprender a usar la aplicación
2. Consulta la [Documentación Técnica](Technical-Documentation) para entender el código
3. Revisa el [Modelo de Datos](Data-Model) para comprender la estructura de datos

## 💡 Consejos

- **Desarrollo Rápido**: Usa el Hot Reload de .NET MAUI para ver cambios en tiempo real
- **Depuración**: Establece puntos de interrupción para debuggear el código
- **Multi-dispositivo**: Prueba la aplicación en diferentes dispositivos y tamaños de pantalla
- **Logs**: Usa `Debug.WriteLine()` para registrar información durante el desarrollo
