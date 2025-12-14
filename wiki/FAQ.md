# ❓ Preguntas Frecuentes (FAQ)

Respuestas a las preguntas más comunes sobre EmpresaTurismo.

## 🏁 Instalación y Configuración

### ¿Qué necesito para ejecutar la aplicación?

Necesitas:
- Visual Studio 2022 (versión 17.8 o superior)
- .NET 9.0 SDK
- Carga de trabajo de .NET MAUI instalada en Visual Studio

Para más detalles, consulta la [Guía de Instalación](Installation-and-Setup).

### ¿En qué plataformas funciona?

EmpresaTurismo es multiplataforma y funciona en:
- 📱 Android (API 21+)
- 🍎 iOS (iOS 11+)
- 💻 Windows (Windows 10 1809+)
- 🖥️ macOS (macOS 11+)

### ¿Cómo ejecuto la aplicación en Android?

1. Abre la solución en Visual Studio
2. Selecciona "Android Emulator" o tu dispositivo Android en la barra de herramientas
3. Presiona F5 o el botón de play

### ¿Puedo ejecutar la aplicación sin Visual Studio?

Sí, puedes usar Visual Studio Code con extensiones de .NET MAUI, o compilar desde la línea de comandos usando `dotnet build` y `dotnet run`.

## 📱 Uso de la Aplicación

### ¿Cuántas rutas puedo crear?

No hay un límite definido. Puedes crear tantas rutas como necesites, limitado solo por la memoria del dispositivo.

### ¿Los datos se guardan permanentemente?

**No**. Actualmente, los datos solo se almacenan en memoria mientras la aplicación está en ejecución. Al cerrar completamente la app, se pierden las rutas creadas y solo permanecen las 6 rutas de ejemplo que se cargan al iniciar.

### ¿Puedo editar el nombre o la distancia de una ruta existente?

Actualmente, solo puedes modificar:
- La dificultad de una ruta
- Las etiquetas de una ruta

Para cambiar otros campos (nombre, distancia, desnivel, etc.), necesitas:
1. Eliminar la ruta existente
2. Crear una nueva ruta con los datos correctos

### ¿Cómo elimino una ruta?

1. Ve a la pestaña "Eliminar Ruta" (🗑️)
2. Selecciona la ruta del menú desplegable
3. Revisa la información mostrada
4. Pulsa "Eliminar Ruta"
5. Confirma en el diálogo

⚠️ **Advertencia**: La eliminación es permanente y no se puede deshacer.

### ¿Puedo buscar rutas por nombre?

Actualmente no hay una función de búsqueda por nombre. Puedes:
- Ver todas las rutas en "Ver Rutas"
- Filtrar por provincia en "Ver Rutas por Provincia"
- Filtrar por etiquetas en "Ver Rutas por Etiquetas"

**Consejo**: Usa etiquetas descriptivas para facilitar la búsqueda.

### ¿Qué significan los niveles de dificultad?

- **FACIL**: Rutas aptas para principiantes, generalmente < 7 km, < 300m desnivel
- **MEDIA**: Rutas moderadas, generalmente 7-15 km, 300-800m desnivel
- **DIFICIL**: Rutas exigentes, generalmente > 15 km, > 800m desnivel

### ¿Puedo cambiar la dificultad de una ruta?

Sí:
1. Ve a "Modificar Ruta" → "Modificar Dificultad"
2. Selecciona la ruta
3. Selecciona la nueva dificultad
4. Confirma el cambio

## 🏷️ Etiquetas

### ¿Cuántas etiquetas puedo añadir a una ruta?

No hay límite. Puedes añadir tantas etiquetas como consideres útiles.

### ¿Puedo añadir una etiqueta duplicada?

No, la aplicación valida que no se añadan etiquetas duplicadas a una misma ruta.

### ¿Cómo añado etiquetas al crear una ruta?

En el formulario de "Crear Ruta", hay un campo "Etiquetas". Introduce las etiquetas separadas por comas:

```
Montaña, Río, Bosque, Panorámica
```

### ¿Cómo añado etiquetas a una ruta existente?

1. Ve a "Modificar Ruta" → "Añadir o Eliminar"
2. Selecciona la ruta
3. Escribe la nueva etiqueta
4. Pulsa "Añadir Etiqueta"

### ¿Cómo elimino una etiqueta?

1. Ve a "Modificar Ruta" → "Añadir o Eliminar"
2. Selecciona la ruta
3. Se mostrará la lista de etiquetas actuales
4. Selecciona la etiqueta a eliminar
5. Pulsa "Eliminar Etiqueta Seleccionada"

### ¿Qué etiquetas debería usar?

Usa etiquetas que describan características de la ruta:
- **Geográficas**: Montaña, Valle, Costa, Río, Lago
- **Vegetación**: Bosque, Prados, Matorral
- **Dificultad**: Técnica, Familiar, Expertos
- **Vistas**: Panorámica, Cumbre, Mirador
- **Actividades**: Bici, Running, Fotografía
- **Época**: Primavera, Verano, Otoño, Invierno

## 📊 Estadísticas

### ¿Qué estadísticas puedo ver?

En "Ver Rutas" → "Ver Estadísticas Rutas" puedes ver:
- Total de rutas en el sistema
- Distancia media de todas las rutas
- Ruta más larga (nombre, distancia, provincia)
- Ruta más corta (nombre, distancia, provincia)
- Ruta con mayor desnivel
- Ruta con menor desnivel

### ¿Las estadísticas se actualizan automáticamente?

Sí, las estadísticas se actualizan automáticamente cuando:
- Entras en la página de estadísticas
- Pulsas el botón "Actualizar"

### ¿Puedo exportar las estadísticas?

No, actualmente no hay función de exportación de estadísticas.

## 🔍 Filtros

### ¿Cómo filtro rutas por provincia?

1. Ve a "Ver Rutas" → "Ver Rutas Provincia"
2. Selecciona una provincia del menú desplegable
3. Se mostrarán solo las rutas de esa provincia

### ¿Cómo filtro rutas por etiqueta?

1. Ve a "Ver Rutas" → "Ver Rutas Etiquetas"
2. Escribe la etiqueta que buscas
3. Pulsa "Buscar por Etiqueta"
4. Se mostrarán todas las rutas que contengan esa etiqueta

### ¿Puedo filtrar por múltiples criterios a la vez?

No, actualmente solo puedes aplicar un filtro a la vez (provincia o etiqueta).

## 📍 Datos de Rutas

### ¿Qué significa "Circular"?

Una ruta circular es aquella en la que el punto de inicio y el punto final son el mismo. No necesitas transporte de vuelta.

Una ruta lineal tiene puntos de inicio y final diferentes, por lo que necesitas planificar cómo volver al inicio.

### ¿Qué es el desnivel?

El desnivel es la suma de todas las subidas (metros de ascenso acumulado) durante la ruta. No incluye las bajadas.

Por ejemplo, una ruta con 500m de desnivel significa que subes 500 metros en total.

### ¿Qué formato tiene el ID de la ruta?

El ID es un identificador único de texto. El formato recomendado es "R" seguido de un número:
- R001
- R002
- R003
- etc.

Pero puedes usar cualquier formato que prefieras, siempre que sea único.

### ¿Para qué sirve la fecha de apertura?

La fecha de apertura indica cuándo se inauguró o abrió oficialmente la ruta. Es útil para:
- Conocer rutas nuevas
- Filtrar por antigüedad (funcionalidad futura)
- Mantener un historial

## 🔧 Problemas Técnicos

### La aplicación no se ejecuta en Android

Verifica que:
1. Tienes el Android SDK instalado
2. El emulador de Android está configurado
3. Has restaurado los paquetes NuGet

Consulta la [Guía de Instalación](Installation-and-Setup#solución-de-problemas) para más detalles.

### Aparece un error al crear una ruta

Verifica que:
- Todos los campos obligatorios estén completos
- El ID no esté duplicado
- La distancia y el desnivel sean números válidos
- Hayas seleccionado una dificultad

### No veo las rutas que creé después de cerrar la app

Esto es el comportamiento esperado. Los datos solo se almacenan en memoria y se pierden al cerrar la aplicación. Solo las 6 rutas de ejemplo persisten (se cargan al iniciar).

### La aplicación está lenta

- Cierra y vuelve a abrir la aplicación
- Si tienes muchas rutas (cientos), el rendimiento puede verse afectado
- Verifica que no haya otros procesos consumiendo recursos

### No puedo compilar el proyecto

Verifica que:
1. Tienes .NET 9.0 SDK instalado
2. Tienes la carga de trabajo de .NET MAUI instalada
3. Has restaurado los paquetes NuGet: `dotnet restore`

## 💡 Mejores Prácticas

### ¿Cómo organizo mejor mis rutas?

**Usa IDs consistentes**:
```
R001, R002, R003, ...
```

**Añade etiquetas descriptivas**:
```
Montaña, Río, Familiar, Panorámica
```

**Sé preciso con los datos**:
- Mide distancias con GPS
- Calcula desnivel con altímetro
- Clasifica dificultad honestamente

### ¿Cómo evito perder mis datos?

Actualmente no hay persistencia de datos. Para futuras versiones, se planea implementar:
- Almacenamiento local en SQLite
- Exportación a JSON
- Sincronización en la nube

### ¿Cuándo debería usar cada nivel de dificultad?

**FACIL**:
- Senderos bien marcados
- Poco desnivel (< 300m)
- Distancia corta (< 7 km)
- Apto para familias con niños

**MEDIA**:
- Senderos con alguna dificultad
- Desnivel moderado (300-800m)
- Distancia media (7-15 km)
- Requiere algo de experiencia

**DIFICIL**:
- Senderos técnicos o exigentes
- Mucho desnivel (> 800m)
- Larga distancia (> 15 km)
- Solo para senderistas experimentados

## 📱 Funcionalidades Futuras

### ¿Se añadirán más funcionalidades?

Este es un proyecto académico, pero posibles mejoras incluyen:
- 💾 Persistencia de datos (SQLite)
- 🗺️ Integración con mapas
- 📸 Añadir fotos a las rutas
- 📊 Más estadísticas y gráficos
- 🔍 Búsqueda avanzada
- 📤 Exportar/importar datos
- 🌐 Compartir rutas entre usuarios
- ⭐ Sistema de valoraciones
- 📝 Comentarios y notas
- 🚩 Puntos de interés en la ruta

### ¿Se puede contribuir al proyecto?

Consulta la [Guía de Contribución](Contributing-Guide) para información sobre cómo contribuir.

## 🆘 Soporte

### ¿Dónde puedo obtener más ayuda?

- **Guía de Usuario**: [User Guide](User-Guide)
- **Documentación Técnica**: [Technical Documentation](Technical-Documentation)
- **Arquitectura**: [Architecture and Design](Architecture-and-Design)
- **Modelo de Datos**: [Data Model](Data-Model)
- **Referencia API**: [API Reference](API-Reference)

### ¿Cómo reporto un bug?

Este es un proyecto académico. Para reportar bugs o sugerir mejoras, contacta con el desarrollador a través del repositorio de GitHub.

## 📚 Información Académica

### ¿Este es un proyecto real?

Sí, es un proyecto académico desarrollado como práctica final para la asignatura de Tecnologías Móviles en la Universidad Pontificia de Salamanca (UPSA), 4º curso.

### ¿Puedo usar este código para mi proyecto?

Este proyecto es de carácter académico. Consulta la licencia y créditos apropiados si deseas usar el código.

### ¿Qué he aprendido con este proyecto?

Este proyecto demuestra conocimientos en:
- .NET MAUI para desarrollo multiplataforma
- C# y programación orientada a objetos
- XAML para diseño de interfaces
- Navegación en aplicaciones móviles
- Data binding y ObservableCollection
- LINQ para consultas de datos
- Patrones de diseño (MVVM simplificado)
- Gestión de estado de aplicación

## 🔗 Enlaces Útiles

- [Repositorio GitHub](https://github.com/dalonsogomez/practica-final-tec-moviles)
- [.NET MAUI Documentation](https://learn.microsoft.com/en-us/dotnet/maui/)
- [C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)

---

**¿No encuentras tu pregunta?** Consulta las otras páginas de la wiki o revisa el código fuente del proyecto.
