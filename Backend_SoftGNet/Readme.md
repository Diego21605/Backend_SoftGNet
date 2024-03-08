# Proyecto en .NET 8.0 con .NET Web API

Este proyecto es una aplicación web API desarrollada en .NET 8.0 que utiliza una base de datos SQL Server para almacenar datos relacionados con conductores, vehículos, usuarios, roles, rutas y programación.

## Tecnologías utilizadas

- .NET 8.0
- .NET Web API
- SQL Server
- JWT (Json Web Token) para autenticación

## Modelos o Tablas

1. Drivers (Conductores)
2. Vehicles (Vehículos)
3. Users (Usuarios)
4. Role (Roles)
5. Routes (Rutas)
6. Scheduler (Programación)

## Funcionalidades

El API proporciona las siguientes funcionalidades:

- Gestión de conductores, vehículos, usuarios, roles, rutas y programación.
- Autenticación mediante JWT para acceder a las funciones protegidas del API.

## Configuración

1. Clona este repositorio.
2. Asegúrate de tener instalado .NET 8.0 y SQL Server.
3. Configura la cadena de conexión a la base de datos en `appsettings.json`.
4. Ejecuta las migraciones de Entity Framework Core para crear la estructura de la base de datos:

```bash
dotnet ef database update