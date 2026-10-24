# AutoevaluacionFormativa_Grupo 5
# Sistema de Gestión Escolar

Aplicación web desarrollada en ASP.NET Core MVC con Entity Framework Core para administrar estudiantes, maestros, aulas, libros y materias.

Proyecto del Grupo 5 — Autoevaluación Formativa.

## Integrantes y entidad desarrollada

| Integrante | Usuario de GitHub | Entidad desarrollada |
|---|---|---|
| Santiago Ortega | SantiOrtega125 | Libros (y creación del proyecto base) |
| Brayan Mendoza | skyshoto | Maestros |
| Milton Yuxi | MiltonYuxi | Estudiantes |
| Claudio Villalba | cdvillalba2 | Aulas |
| Alan Neira | Niclik05 | Materias (y menú de botones de la página de inicio) |

## Menú principal

Al ejecutar el proyecto se abre la página de inicio con un botón por cada entidad. Cada botón lleva a su CRUD (listar, crear, ver detalles, editar y eliminar):

| Botón | Ruta |
|---|---|
| Estudiantes | `/Estudiantes` |
| Maestros | `/Maestros` |
| Aulas | `/Aulas` |
| Libros | `/Libros` |
| Materias | `/Materias` |

## Requisitos

- Visual Studio 2022 o superior con la carga de trabajo **Desarrollo de ASP.NET y web**.
- SQL Server LocalDB (se instala junto con Visual Studio).

## Pasos para ejecutar el proyecto

### 1. Clonar el repositorio

```bash
git clone https://github.com/SantiOrtega125/AutoevaluacionFormativa_Grupo10.git
```

También se puede hacer desde Visual Studio con **Git → Clonar repositorio...** pegando la URL.

### 2. Abrir la solución

Abrir el archivo `Biblioteca1.sln` con Visual Studio.


### 3. Crear la base de datos

En **Herramientas → Administrador de paquetes NuGet → Consola del Administrador de paquetes**, ejecutar:

```
Update-Database
```

Este comando aplica las migraciones de la carpeta `Migrations` y crea la base de datos con las tablas de todas las entidades.

### 4. Ejecutar

Presionar **F5** o el botón **https** de la barra superior. Se abrirá el navegador con la página de inicio del sistema.
