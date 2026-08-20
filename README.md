# Sistema de Gestión de Asignaciones de Laboratorio Clínico (LabClinicoAPI)

##  Descripción del Proyecto
Sistema desarrollado en .NET Core para la automatización y gestión de un laboratorio clínico, permitiendo el control de pacientes, catálogo de pruebas médicas y asignación de órdenes de laboratorio mediante una arquitectura API REST.

##  Tecnologías Utilizadas
- **Backend:** C#, .NET 8 / Web API
- **Base de Datos:** SQL Server / Entity Framework Core
- **Control de Versiones:** Git & GitHub

##  Estructura de Capas
- **Models:** Entidades del dominio (`Paciente`, `Prueba`).
- **Data:** Contexto de persistencia de datos (`ApplicationDbContext`).
- **Controllers:** Endpoints de la API REST.

##  Cómo Ejecutar el Proyecto
1. Clonar el repositorio.
2. Configurar la cadena de conexión en `appsettings.json`.
3. Ejecutar las migraciones de Entity Framework o respaldar la base de datos SQL Server.
4. Iniciar el proyecto desde Visual Studio o mediante la terminal con `dotnet run`.
