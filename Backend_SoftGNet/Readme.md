# Proyecto en .NET 8.0 con .NET Web API

Este proyecto es una aplicaci�n web API desarrollada en .NET 8.0 que utiliza una base de datos SQL Server para almacenar datos relacionados con conductores, veh�culos, usuarios, roles, rutas y programaci�n.

## Tecnolog�as utilizadas

- .NET 8.0
- .NET Web API
- SQL Server
- JWT (Json Web Token) para autenticaci�n

## Modelos o Tablas

1. Drivers (Conductores)
2. Vehicles (Veh�culos)
3. Users (Usuarios)
4. Role (Roles)
5. Routes (Rutas)
6. Scheduler (Programaci�n)

## Funcionalidades

El API proporciona las siguientes funcionalidades:

- Gesti�n de conductores, veh�culos, usuarios, roles, rutas y programaci�n.
- Autenticaci�n mediante JWT para acceder a las funciones protegidas del API.

## Configuraci�n

1. Clona este repositorio.
2. Aseg�rate de tener instalado .NET 8.0 y SQL Server.
3. Configura la cadena de conexi�n a la base de datos en `appsettings.json`.
4. Ejecuta las migraciones de Entity Framework Core para crear la estructura de la base de datos:

```bash
dotnet ef database update