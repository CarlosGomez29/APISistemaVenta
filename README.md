# APISistemaVenta

API desarrollada en ASP.NET Core (.NET 8) para la gestión de ventas, usuarios, roles y reportes. Este proyecto está estructurado en varias capas y módulos, facilitando la escalabilidad y el mantenimiento.

## Características principales

- Gestión de ventas: registro, historial y reportes.
- Gestión de usuarios y roles.
- Dashboard con resumen de la actividad.
- Arquitectura en capas: API, BLL (lógica de negocio), DAL (acceso a datos), DTO (objetos de transferencia).
- Uso de Swagger para documentación y pruebas.
- CORS habilitado para permitir acceso desde cualquier origen.

## Estructura del proyecto

- **SistemaVenta.API**: Proyecto principal de la API.
- **SistemaVenta.BLL**: Lógica de negocio y servicios.
- **SistemaVenta.DAL**: Acceso a datos y repositorios.
- **SistemaVenta.DTO**: Objetos de transferencia de datos.
- **SistemaVenta.Model**: Modelos de entidades.
- **SistemaVenta.IOC**: Inyección de dependencias.
- **SistemaVenta.Utility**: Mapeo de objetos con AutoMapper.

## Instalación

1. Clona el repositorio:
  git clone https://github.com/CarlosGomez29/APISistemaVenta.git
2. Abre la solución en Visual Studio 2022.
3. Restaura los paquetes NuGet (__Herramientas > Administrador de paquetes NuGet > Restaurar paquetes__).
4. Configura la cadena de conexión en el archivo `appsettings.json` de `SistemaVenta.API` según tu base de datos.
5. Compila la solución (__Compilar > Compilar solución__).

## Ejecución

1. Ejecuta el proyecto `SistemaVenta.API` como proyecto de inicio.
2. Accede a la documentación Swagger en `http://localhost:<puerto>/swagger` para probar los endpoints.

## Endpoints principales

### Ventas

- `POST /api/Venta/Registrar`: Registrar una nueva venta.
- `GET /api/Venta/Historial`: Consultar historial de ventas (filtros por número, fecha, etc.).
- `GET /api/Venta/Reporte`: Obtener reportes de ventas por rango de fechas.

### Dashboard

- `GET /api/DashBoard/Resumen`: Obtener resumen de la actividad.

### Roles y Usuarios

- Endpoints para gestión de roles y usuarios disponibles en sus respectivos controladores.

## Configuración adicional

- **CORS**: Configurado para permitir cualquier origen, encabezado y método.
- **Swagger**: Habilitado en entorno de desarrollo para documentación interactiva.
- **Inyección de dependencias**: Configurada en `SistemaVenta.IOC` y registrada en `Program.cs`.

## Requisitos

- .NET 8 SDK
- SQL Server (o la base de datos configurada en la cadena de conexión)
- Visual Studio 2022

---

**Autor:** Carlos Gomez  
**Repositorio:** [APISistemaVenta](https://github.com/CarlosGomez29/APISistemaVenta)
