# Wiki de EmpresaTurismo

Este directorio contiene la documentación completa de la aplicación EmpresaTurismo en formato de wiki.

## 📚 Estructura de la Wiki

### Páginas Disponibles

1. **[Home.md](Home.md)** - Página principal de la wiki con índice y resumen
2. **[Installation-and-Setup.md](Installation-and-Setup.md)** - Guía de instalación y configuración
3. **[User-Guide.md](User-Guide.md)** - Manual de usuario completo
4. **[Architecture-and-Design.md](Architecture-and-Design.md)** - Arquitectura y patrones de diseño
5. **[Data-Model.md](Data-Model.md)** - Documentación del modelo de datos
6. **[API-Reference.md](API-Reference.md)** - Referencia de clases y métodos
7. **[Technical-Documentation.md](Technical-Documentation.md)** - Documentación técnica detallada
8. **[FAQ.md](FAQ.md)** - Preguntas frecuentes
9. **[Contributing-Guide.md](Contributing-Guide.md)** - Guía para contribuir al proyecto
10. **[Screenshots-and-Examples.md](Screenshots-and-Examples.md)** - Ejemplos visuales y de código

## 🚀 Uso de la Wiki

### Para Usuarios
- Comienza con **Home.md** para tener una visión general
- Lee **Installation-and-Setup.md** para instalar la aplicación
- Consulta **User-Guide.md** para aprender a usar todas las funcionalidades
- Revisa **FAQ.md** si tienes preguntas comunes

### Para Desarrolladores
- Lee **Architecture-and-Design.md** para entender la arquitectura
- Consulta **Data-Model.md** para conocer la estructura de datos
- Revisa **API-Reference.md** para documentación de clases
- Lee **Technical-Documentation.md** para detalles de implementación
- Sigue **Contributing-Guide.md** si quieres contribuir

### Para Instructores/Evaluadores
- **Home.md** - Resumen ejecutivo del proyecto
- **Architecture-and-Design.md** - Decisiones de diseño y patrones
- **Technical-Documentation.md** - Aspectos técnicos y tecnologías
- **Screenshots-and-Examples.md** - Demostraciones visuales

## 📖 Cómo Publicar en GitHub Wiki

Para publicar esta documentación como GitHub Wiki oficial:

### Opción 1: Mediante la Interfaz Web de GitHub

1. Ve a tu repositorio en GitHub
2. Haz clic en la pestaña "Wiki"
3. Crea nuevas páginas copiando el contenido de cada archivo .md
4. El archivo `Home.md` será la página principal

### Opción 2: Mediante Git (Clonar Wiki)

```bash
# Clonar el wiki del repositorio
git clone https://github.com/dalonsogomez/practica-final-tec-moviles.wiki.git

# Copiar los archivos
cp wiki/*.md practica-final-tec-moviles.wiki/

# Hacer commit y push
cd practica-final-tec-moviles.wiki
git add .
git commit -m "Añadir documentación completa de la wiki"
git push origin master
```

### Opción 3: Script Automático

```bash
#!/bin/bash
# publish-wiki.sh

WIKI_REPO="https://github.com/dalonsogomez/practica-final-tec-moviles.wiki.git"
TEMP_DIR="/tmp/wiki-publish"

# Clonar wiki
git clone "$WIKI_REPO" "$TEMP_DIR"

# Copiar archivos
cp wiki/*.md "$TEMP_DIR/"

# Commit y push
cd "$TEMP_DIR"
git add .
git commit -m "Update wiki documentation"
git push origin master

# Limpiar
rm -rf "$TEMP_DIR"
```

## 🔄 Mantenimiento

### Actualizar la Wiki

Cuando hagas cambios en el código que afecten la documentación:

1. Actualiza los archivos correspondientes en `wiki/`
2. Haz commit de los cambios
3. Sincroniza con GitHub Wiki usando uno de los métodos anteriores

### Convenciones de Nomenclatura

- Nombres de archivo en formato `Titulo-Con-Guiones.md`
- Las referencias internas usan el nombre del archivo sin extensión: `[Texto](Nombre-Archivo)`
- Usa emojis para mejorar la legibilidad: 📱 🔧 📚 etc.

## 📝 Convenciones de Formato

### Encabezados
```markdown
# Título Principal (H1)
## Sección (H2)
### Subsección (H3)
#### Detalle (H4)
```

### Código
```markdown
\`\`\`csharp
// Bloques de código con lenguaje especificado
public class Ejemplo { }
\`\`\`

`código inline`
```

### Enlaces
```markdown
[Texto del enlace](Ruta-O-URL)
```

### Listas
```markdown
- Elemento 1
- Elemento 2
  - Sub-elemento

1. Primero
2. Segundo
```

### Tablas
```markdown
| Columna 1 | Columna 2 |
|-----------|-----------|
| Dato 1    | Dato 2    |
```

## 📊 Estadísticas de la Wiki

- **Total de páginas**: 10
- **Palabras aproximadas**: ~25,000
- **Líneas de código de ejemplo**: ~500
- **Diagramas y tablas**: ~20

## 🎯 Cobertura de Documentación

- ✅ Instalación y configuración
- ✅ Guía de usuario completa
- ✅ Arquitectura y diseño
- ✅ Modelo de datos
- ✅ Referencia de API
- ✅ Documentación técnica
- ✅ FAQ
- ✅ Guía de contribución
- ✅ Ejemplos y capturas

## 📞 Contacto

Para preguntas sobre la documentación:
- Repositorio: [GitHub](https://github.com/dalonsogomez/practica-final-tec-moviles)
- Asignatura: Tecnologías Móviles - UPSA

---

**Última actualización**: Diciembre 2024
