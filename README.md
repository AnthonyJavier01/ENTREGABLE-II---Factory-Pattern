# Factory Pattern - Sistema de Notificaciones

## Descripción General

Este proyecto consiste en una aplicación de consola desarrollada en C# que implementa el patrón de diseño **Factory Pattern** para la creación de diferentes tipos de notificadores.

La aplicación permite al usuario seleccionar un canal de notificación y enviar un mensaje utilizando dicho canal.

Los tipos de notificadores disponibles son:

- Email
- SMS
- Teams

La creación de estos objetos se encuentra centralizada en una fábrica denominada `NotificadorFactory`, permitiendo desacoplar la lógica de creación de objetos del código cliente.

---

# Objetivo del Entregable

Implementar el patrón de diseño **Factory Pattern** con el fin de desacoplar la creación de objetos y facilitar la extensibilidad de la aplicación.

La aplicación debe retornar un tipo de notificador según el parámetro seleccionado por el usuario:

- Email
- SMS
- Teams

---

# Patrón de Diseño Aplicado

## Factory Pattern

El patrón Factory permite encapsular la lógica de creación de objetos dentro de una clase especializada denominada fábrica.

Sin Factory:

```csharp
var email = new EmailNotificador();
```

El código cliente depende directamente de una implementación concreta.

Con Factory:

```csharp
var notificador = factory.CrearNotificador(tipo);
```

El código cliente solo conoce la interfaz:

```csharp
INotificador
```

y delega la creación del objeto a la fábrica.

---

# Estructura del Proyecto

```text

├── Factories
│   └── NotificadorFactory.cs
│
├── Interfaces
│   ├── INotificador.cs
│   └── INotificadorFactory.cs
│
├── Notificadores
│   ├── EmailNotificador.cs
│   ├── SmsNotificador.cs
│   └── TeamsNotificador.cs
│
└── Program.cs
```

---
# Ejecución del Proyecto
 
## Requisitos
 
- .NET 10 
- Visual Studio 2026 o Visual Studio Code.
 
## Compilar el Proyecto
 
Abrir una terminal en la carpeta raíz del proyecto y ejecutar:
 
```bash
dotnet build
```
 
## Ejecutar el Proyecto
 
```bash
dotnet run
```

           