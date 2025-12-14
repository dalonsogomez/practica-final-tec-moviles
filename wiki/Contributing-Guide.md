# 🤝 Guía de Contribución

Bienvenido! Esta guía te ayudará a contribuir al proyecto EmpresaTurismo.

## 📋 Antes de Empezar

### Requisitos Previos

Asegúrate de tener instalado:
- Visual Studio 2022 (17.8+) con carga de trabajo .NET MAUI
- .NET 9.0 SDK
- Git para control de versiones
- Conocimientos de C# y XAML

Consulta la [Guía de Instalación](Installation-and-Setup) para más detalles.

## 🌟 Tipos de Contribuciones

Aceptamos varios tipos de contribuciones:

### 🐛 Reporte de Bugs
- Describe el problema claramente
- Incluye pasos para reproducirlo
- Especifica el entorno (Windows/macOS/Android/iOS)
- Adjunta capturas de pantalla si es posible

### ✨ Nuevas Funcionalidades
- Explica el caso de uso
- Describe el comportamiento esperado
- Considera el impacto en funcionalidades existentes

### 📝 Documentación
- Mejoras en la wiki
- Comentarios en el código
- Tutoriales y ejemplos
- Correcciones de typos

### 🎨 Mejoras de UI/UX
- Diseños mejorados
- Mejor experiencia de usuario
- Accesibilidad
- Consistencia visual

### 🔧 Refactorización
- Mejorar estructura del código
- Optimizar rendimiento
- Eliminar código duplicado
- Aplicar mejores prácticas

## 🔄 Proceso de Contribución

### 1. Fork y Clone

```bash
# Fork el repositorio en GitHub, luego:
git clone https://github.com/TU_USUARIO/practica-final-tec-moviles.git
cd practica-final-tec-moviles
```

### 2. Crear una Rama

```bash
git checkout -b feature/nombre-de-tu-funcionalidad
# o
git checkout -b fix/nombre-del-bug
```

**Convención de nombres de ramas**:
- `feature/` - Nuevas funcionalidades
- `fix/` - Corrección de bugs
- `docs/` - Cambios en documentación
- `refactor/` - Refactorización de código
- `style/` - Cambios de estilo/formato

### 3. Realizar Cambios

Haz tus cambios siguiendo las [Guías de Estilo](#-guías-de-estilo).

### 4. Commit

```bash
git add .
git commit -m "Descripción clara del cambio"
```

**Convención de mensajes de commit**:
```
tipo: descripción breve

Descripción más detallada si es necesaria.

Fixes #123
```

**Tipos de commit**:
- `feat:` - Nueva funcionalidad
- `fix:` - Corrección de bug
- `docs:` - Cambios en documentación
- `style:` - Formato, puntos y comas, etc.
- `refactor:` - Refactorización de código
- `test:` - Añadir o modificar tests
- `chore:` - Mantenimiento

**Ejemplos**:
```bash
git commit -m "feat: añadir búsqueda de rutas por nombre"
git commit -m "fix: corregir validación de distancia negativa"
git commit -m "docs: actualizar guía de instalación para macOS"
```

### 5. Push

```bash
git push origin feature/nombre-de-tu-funcionalidad
```

### 6. Pull Request

1. Ve a tu fork en GitHub
2. Haz clic en "Pull Request"
3. Completa la plantilla de PR:
   - Título descriptivo
   - Descripción detallada de los cambios
   - Referencia a issues relacionados
   - Capturas de pantalla (si aplica)

## 📐 Guías de Estilo

### Código C#

#### Convenciones de Nomenclatura

```csharp
// PascalCase para clases, métodos, propiedades
public class RutaManager
{
    public string NombreRuta { get; set; }
    
    public void CrearRuta()
    {
        // ...
    }
}

// camelCase para variables locales y parámetros
public void ProcesarRuta(string nombreRuta)
{
    int contadorRutas = 0;
    // ...
}

// PascalCase para constantes
public const int MaximaDistancia = 100;

// _camelCase para campos privados
private string _nombreInterno;
```

#### Formato y Estructura

```csharp
// Espacios en operadores
int suma = a + b;

// Llaves en nueva línea (estilo Allman)
if (condicion)
{
    // código
}

// Espacios después de palabras clave
if (condicion)
while (condicion)
for (int i = 0; i < 10; i++)

// Usar var cuando el tipo es obvio
var rutas = new List<Ruta>();
var nombre = "Ruta 1";

// Declarar tipo cuando no es obvio
DatosMock rutas = ObtenerRutas();
```

#### Comentarios

```csharp
// Comentarios de una línea para explicaciones breves

/// <summary>
/// Comentarios XML para documentar métodos públicos
/// </summary>
/// <param name="id">El identificador de la ruta</param>
/// <returns>La ruta encontrada o null</returns>
public Ruta BuscarPorId(string id)
{
    // Implementación
}
```

### Código XAML

#### Formato

```xml
<!-- Atributos en líneas separadas si son muchos -->
<Button Text="Guardar"
        BackgroundColor="#2E7D32"
        TextColor="White"
        CornerRadius="10"
        Clicked="OnGuardarClicked" />

<!-- En una línea si son pocos atributos -->
<Label Text="Título" FontSize="20" />

<!-- Indentación consistente -->
<VerticalStackLayout Spacing="10">
    <Label Text="Nombre:" />
    <Entry x:Name="NombreEntry" />
    <Button Text="Guardar" />
</VerticalStackLayout>
```

#### Nomenclatura en XAML

```xml
<!-- x:Name en PascalCase -->
<Entry x:Name="NombreRutaEntry" />
<Button x:Name="GuardarButton" />

<!-- Sufijo según el tipo de control -->
<Entry x:Name="DistanciaEntry" />
<Picker x:Name="DificultadPicker" />
<Label x:Name="TituloLabel" />
<Button x:Name="CrearButton" />
```

### Organización de Archivos

```
EmpresaTurismo/
├── Models/              # (futuro) Modelos de datos
│   └── Ruta.cs
├── Views/               # (futuro) Vistas XAML
│   └── CrearRuta.xaml
├── ViewModels/          # (futuro) ViewModels
│   └── CrearRutaViewModel.cs
└── Services/            # (futuro) Servicios
    └── RutaService.cs
```

## ✅ Checklist Antes de PR

Antes de enviar tu Pull Request, verifica:

- [ ] El código compila sin errores
- [ ] El código sigue las guías de estilo
- [ ] Has probado los cambios en al menos una plataforma
- [ ] No hay warnings del compilador (o están justificados)
- [ ] Los cambios no rompen funcionalidad existente
- [ ] Has actualizado la documentación si es necesario
- [ ] El commit tiene un mensaje descriptivo
- [ ] Has hecho squash de commits innecesarios

## 🧪 Testing

### Tests Manuales

Antes de enviar tu PR, prueba:

1. **Funcionalidad nueva/modificada**:
   - Casos normales
   - Casos extremos
   - Casos de error

2. **Regresión**:
   - Funcionalidades relacionadas
   - Navegación
   - Datos persistentes

3. **Multiplataforma** (si es posible):
   - Android
   - iOS
   - Windows
   - macOS

### Tests Automatizados (futuro)

Si añades funcionalidad compleja, considera añadir tests unitarios:

```csharp
[Fact]
public void CrearRuta_ConDatosValidos_CreaRutaCorrectamente()
{
    // Arrange
    var manager = new RutaManager();
    
    // Act
    var ruta = manager.CrearRuta("R001", "Test", ...);
    
    // Assert
    Assert.NotNull(ruta);
    Assert.Equal("R001", ruta.Id);
}
```

## 🎨 Estándares de Diseño

### Colores

Usa la paleta definida en `Resources/Styles/Colors.xaml`:

```xml
<Color x:Key="Primary">#2E7D32</Color>      <!-- Verde principal -->
<Color x:Key="Secondary">#81C784</Color>    <!-- Verde claro -->
<Color x:Key="Tertiary">#1B5E20</Color>     <!-- Verde oscuro -->
```

### Espaciado

```xml
<!-- Espaciado consistente -->
<VerticalStackLayout Spacing="10">
    <!-- Contenido -->
</VerticalStackLayout>

<!-- Padding consistente -->
<Frame Padding="20">
    <!-- Contenido -->
</Frame>
```

### Fuentes

```xml
<!-- Tamaños de fuente consistentes -->
<Label FontSize="24" />  <!-- Títulos -->
<Label FontSize="18" />  <!-- Subtítulos -->
<Label FontSize="14" />  <!-- Texto normal -->
<Label FontSize="12" />  <!-- Texto pequeño -->
```

## 📱 Consideraciones Multiplataforma

### Código Específico de Plataforma

Usa compilación condicional cuando sea necesario:

```csharp
#if ANDROID
    // Código solo para Android
#elif IOS
    // Código solo para iOS
#elif WINDOWS
    // Código solo para Windows
#endif
```

### Pruebas en Múltiples Plataformas

Idealmente, prueba en:
- ✅ Al menos una plataforma móvil (Android o iOS)
- ✅ Al menos una plataforma de escritorio (Windows o macOS)

## 🐛 Reportar Bugs

### Template de Bug Report

```markdown
**Descripción del Bug**
Una descripción clara del problema.

**Pasos para Reproducir**
1. Ve a '...'
2. Haz clic en '...'
3. Desplázate hasta '...'
4. Observa el error

**Comportamiento Esperado**
Qué esperabas que pasara.

**Comportamiento Actual**
Qué pasó realmente.

**Capturas de Pantalla**
Si aplica, añade capturas.

**Entorno**
- Plataforma: [Android/iOS/Windows/macOS]
- Versión del SO: [ej. Android 14]
- Versión de la App: [ej. 1.0]
- Dispositivo: [ej. Pixel 7, iPhone 14]

**Información Adicional**
Cualquier otro contexto relevante.
```

## ✨ Proponer Nuevas Funcionalidades

### Template de Feature Request

```markdown
**Descripción de la Funcionalidad**
Descripción clara de lo que quieres que se añada.

**Problema que Resuelve**
¿Qué problema soluciona esta funcionalidad?

**Solución Propuesta**
Cómo debería funcionar.

**Alternativas Consideradas**
Otras soluciones que consideraste.

**Contexto Adicional**
Mockups, ejemplos, referencias, etc.
```

## 📚 Documentación

### Actualizar la Wiki

Si tu cambio afecta el uso de la aplicación:

1. Actualiza las páginas relevantes de la wiki
2. Añade ejemplos si introduces nueva funcionalidad
3. Actualiza capturas de pantalla si cambia la UI

### Comentar el Código

```csharp
/// <summary>
/// Crea una nueva ruta de senderismo
/// </summary>
/// <param name="id">Identificador único de la ruta</param>
/// <param name="nombre">Nombre descriptivo</param>
/// <param name="dificultad">Nivel de dificultad</param>
/// <returns>La ruta creada</returns>
/// <exception cref="ArgumentException">Si el ID ya existe</exception>
public Ruta CrearRuta(string id, string nombre, Dificultad dificultad)
{
    // Implementación
}
```

## 🔐 Seguridad

Si encuentras una vulnerabilidad de seguridad:

1. **NO** abras un issue público
2. Contacta directamente al mantenedor
3. Proporciona detalles y pasos para reproducir
4. Espera respuesta antes de divulgar

## 📞 Contacto

- **Repositorio**: [GitHub](https://github.com/dalonsogomez/practica-final-tec-moviles)
- **Issues**: [GitHub Issues](https://github.com/dalonsogomez/practica-final-tec-moviles/issues)
- **Asignatura**: Tecnologías Móviles - UPSA

## 📄 Licencia

Al contribuir a este proyecto, aceptas que tus contribuciones se licenciarán bajo la misma licencia que el proyecto.

## 🙏 Agradecimientos

Gracias por considerar contribuir a EmpresaTurismo. Toda contribución, grande o pequeña, es bienvenida y apreciada.

## 💡 Ideas para Contribuir

Si no sabes por dónde empezar, aquí hay algunas ideas:

### Funcionalidades
- [ ] Persistencia de datos con SQLite
- [ ] Búsqueda por nombre de ruta
- [ ] Ordenación personalizable de listas
- [ ] Exportar/importar datos (JSON, CSV)
- [ ] Integración con mapas
- [ ] Añadir fotos a las rutas
- [ ] Sistema de favoritos
- [ ] Compartir rutas

### Mejoras
- [ ] Tests unitarios
- [ ] Tests de UI
- [ ] Mejoras de rendimiento
- [ ] Accesibilidad (lectores de pantalla)
- [ ] Soporte para temas oscuro/claro
- [ ] Internacionalización (i18n)
- [ ] Animaciones y transiciones

### Documentación
- [ ] Tutoriales en video
- [ ] Más ejemplos de código
- [ ] Diagramas de flujo
- [ ] Capturas de pantalla actualizadas
- [ ] Traducir wiki a otros idiomas

---

**¡Esperamos tu contribución!** 🚀
