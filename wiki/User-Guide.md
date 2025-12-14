# 📖 Guía de Usuario

Esta guía completa te mostrará cómo utilizar todas las funcionalidades de EmpresaTurismo.

## 🏠 Pantalla Principal

Al iniciar la aplicación, verás la pantalla de bienvenida con:
- Una imagen de fondo de ruta de senderismo
- Mensaje de bienvenida: "Bienvenido a tu Aventura"
- Barra de navegación inferior con 5 pestañas

## 📱 Navegación Principal

La aplicación utiliza una barra de pestañas en la parte inferior para navegar entre las diferentes secciones:

1. **🏠 Inicio** - Pantalla de bienvenida
2. **➕ Crear Ruta** - Añadir nuevas rutas
3. **👁️ Ver Rutas** - Visualizar y consultar rutas
4. **✏️ Modificar Ruta** - Editar rutas existentes
5. **🗑️ Eliminar Ruta** - Borrar rutas

## ➕ Crear una Nueva Ruta

### Pasos para Crear una Ruta

1. **Acceder a la sección**: Toca la pestaña "Crear Ruta" (segunda pestaña)

2. **Completar el formulario**:
   - **ID**: Identificador único de la ruta (ej: "R007")
   - **Nombre**: Nombre descriptivo de la ruta
   - **Dificultad**: Selecciona entre FACIL, MEDIA o DIFICIL
   - **Distancia (km)**: Longitud de la ruta en kilómetros
   - **Desnivel (m)**: Desnivel acumulado en metros
   - **Provincia**: Provincia donde se encuentra la ruta
   - **Circular**: Activa si la ruta es circular (inicio y fin en el mismo punto)
   - **Fecha de Apertura**: Fecha en que se abrió la ruta
   - **Etiquetas**: Palabras clave separadas por comas (ej: "Montaña, Río, Bosque")

3. **Guardar**: Toca el botón "Crear Ruta"

### Validaciones

- Todos los campos (excepto etiquetas) son obligatorios
- El ID debe ser único
- La distancia y el desnivel deben ser números válidos
- La dificultad debe seleccionarse del menú desplegable

### Ejemplo de Ruta

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

## 👁️ Ver Rutas

La pestaña "Ver Rutas" contiene 4 sub-secciones:

### 1. Ver Rutas (Listado Completo)

Muestra todas las rutas en formato de lista con:
- Nombre de la ruta
- Provincia
- Dificultad
- Distancia en kilómetros

**Características**:
- Lista desplazable de todas las rutas
- Toca una ruta para ver los detalles completos

### 2. Ver Rutas por Provincia

Agrupa y filtra las rutas por provincia:
- Selecciona una provincia del menú desplegable
- Ver todas las rutas de esa provincia
- Información mostrada: Nombre, Dificultad y Distancia

**Provincias disponibles**:
- Ávila
- León
- Burgos
- Salamanca
- Segovia
- Valladolid
- (Todas las provincias con rutas registradas)

### 3. Ver Estadísticas de Rutas

Muestra estadísticas agregadas del sistema:

**Métricas disponibles**:
- 📊 **Total de Rutas**: Número total de rutas en el sistema
- 📏 **Distancia Media**: Promedio de distancia de todas las rutas
- 🥇 **Ruta Más Larga**: Nombre, distancia y provincia
- 🥉 **Ruta Más Corta**: Nombre, distancia y provincia
- ⛰️ **Mayor Desnivel**: Ruta con más desnivel acumulado
- 🏔️ **Menor Desnivel**: Ruta con menos desnivel acumulado

**Actualización**:
- Botón "Actualizar" para refrescar las estadísticas
- Se actualiza automáticamente al entrar en la página

### 4. Ver Rutas por Etiquetas

Filtra las rutas por etiquetas específicas:
- Introduce una etiqueta en el campo de búsqueda
- Toca "Buscar por Etiqueta"
- Ver todas las rutas que contengan esa etiqueta

**Ejemplos de etiquetas**:
- Montaña
- Río
- Bosque
- Cascadas
- Familiar
- Panorámica
- Larga distancia

## ✏️ Modificar Rutas

La pestaña "Modificar Ruta" ofrece 2 opciones:

### 1. Añadir o Eliminar Etiquetas

**Para añadir etiquetas**:
1. Selecciona una ruta del menú desplegable
2. Introduce la nueva etiqueta en el campo "Añadir etiqueta"
3. Toca el botón "Añadir Etiqueta"

**Para eliminar etiquetas**:
1. Selecciona una ruta del menú desplegable
2. Las etiquetas actuales se muestran en una lista
3. Selecciona la etiqueta a eliminar
4. Toca el botón "Eliminar Etiqueta Seleccionada"

**Validaciones**:
- No se pueden añadir etiquetas duplicadas
- No se pueden añadir etiquetas vacías

### 2. Modificar Dificultad

Cambia el nivel de dificultad de una ruta:

1. Selecciona una ruta del primer menú desplegable
2. Se muestra la dificultad actual
3. Selecciona la nueva dificultad del segundo menú (FACIL, MEDIA, DIFICIL)
4. Toca "Modificar Dificultad"
5. Confirma el cambio en el diálogo de confirmación

**Casos de uso**:
- Reclasificar rutas según experiencia real
- Actualizar dificultad por cambios en el terreno
- Corregir clasificaciones iniciales

## 🗑️ Eliminar Rutas

Para eliminar una ruta del sistema:

1. Ve a la pestaña "Eliminar Ruta"
2. Selecciona la ruta a eliminar del menú desplegable
3. Revisa la información mostrada:
   - Nombre de la ruta
   - Provincia
   - Dificultad
   - Distancia
4. Toca el botón "Eliminar Ruta"
5. **Confirma** la eliminación en el diálogo de confirmación

⚠️ **Advertencia**: La eliminación es permanente y no se puede deshacer.

## 🔍 Ver Detalles de una Ruta

Al tocar una ruta en el listado, verás:

- **📝 Nombre**: Nombre completo de la ruta
- **🆔 ID**: Identificador único
- **🎯 Dificultad**: Nivel de dificultad (FACIL, MEDIA, DIFICIL)
- **📏 Distancia**: Longitud en kilómetros
- **⛰️ Desnivel**: Desnivel acumulado en metros
- **📍 Provincia**: Ubicación geográfica
- **🔄 Tipo**: Circular o Lineal
- **📅 Fecha de Apertura**: Cuándo se abrió la ruta
- **🏷️ Etiquetas**: Lista de etiquetas asociadas

## 💡 Consejos de Uso

### Organización de Rutas

1. **Usa IDs consistentes**: Ejemplo: R001, R002, R003...
2. **Etiquetas descriptivas**: Añade múltiples etiquetas para facilitar búsquedas
3. **Sé preciso con la dificultad**: Ayuda a otros usuarios a seleccionar rutas apropiadas

### Búsqueda y Filtrado

1. **Por Provincia**: Útil para planificar viajes a una región específica
2. **Por Etiquetas**: Encuentra rutas con características particulares (ríos, bosques, etc.)
3. **Estadísticas**: Descubre rutas extremas o compara con la media

### Mantenimiento de Datos

1. **Actualiza la dificultad**: Si realizas una ruta y difiere de la clasificación
2. **Añade etiquetas**: Mejora la información después de recorrer la ruta
3. **Elimina duplicados**: Mantén la base de datos limpia

## 🎯 Flujos de Trabajo Comunes

### Planificar una Salida

1. Ve a "Ver Rutas por Provincia"
2. Selecciona tu provincia de interés
3. Revisa las opciones disponibles
4. Toca una ruta para ver detalles completos
5. Evalúa distancia, desnivel y dificultad

### Documentar una Nueva Ruta

1. Ve a "Crear Ruta"
2. Completa toda la información
3. Añade etiquetas descriptivas
4. Guarda la ruta
5. Verifica en "Ver Rutas" que se creó correctamente

### Actualizar Información

1. Ve a "Modificar Ruta"
2. Usa "Modificar Dificultad" si cambió el nivel
3. Usa "Añadir/Eliminar Etiquetas" para actualizar características

## ❓ Preguntas Comunes

**P: ¿Cuántas rutas puedo crear?**  
R: No hay límite definido, puedes crear tantas rutas como necesites.

**P: ¿Puedo editar el nombre o distancia de una ruta?**  
R: Actualmente solo se puede modificar la dificultad y las etiquetas. Para cambiar otros campos, debes eliminar y recrear la ruta.

**P: ¿Los datos se guardan permanentemente?**  
R: Los datos se mantienen en memoria mientras la aplicación está en ejecución. Al cerrar completamente la app, se perderán las rutas creadas y solo permanecerán las 6 rutas de ejemplo.

**P: ¿Puedo exportar o importar rutas?**  
R: Esta funcionalidad no está disponible en la versión actual.

## 🆘 Soporte

Si encuentras problemas o tienes preguntas:
- Consulta las [Preguntas Frecuentes (FAQ)](FAQ)
- Revisa la [Documentación Técnica](Technical-Documentation)
- Verifica la [Guía de Instalación](Installation-and-Setup)
