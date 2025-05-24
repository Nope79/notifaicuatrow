# Notify

**Notify** es una aplicaci�n de escritorio desarrollada en **C# con .NET**, pensada para centralizar notificaciones dentro de una organizaci�n. Permite a los usuarios recibir informaci�n filtrada seg�n sus preferencias mediante un sistema de secciones configurables.

## Caracter�sticas principales

- Gesti�n de usuarios y administradores
- Creaci�n y env�o de notificaciones
- Filtro de notificaciones por **remitente**, **prioridad** o **tema**
- Organizaci�n de usuarios en grupos
- Configuraci�n de secciones personalizadas por usuario

## Arquitectura del sistema

El sistema est� dise�ado en una arquitectura en capas:
- **Presentaci�n:** interfaz gr�fica desarrollada con Windows Forms/WPF.
- **L�gica de negocio:** maneja reglas, permisos y filtrado de notificaciones.
- **Acceso a datos:** gestiona la conexi�n y operaciones sobre la base de datos relacional.

## Requisitos

- .NET Framework 4.7.2 o superior / .NET 6.0 (seg�n versi�n del proyecto)
- Visual Studio 2022 o superior
- MySQL

## Instalaci�n

1. Clona este repositorio:
git clone https://github.com/Nope79/notifaicuatrow

2. Abre la soluci�n en Visual Studio.
3. Configura la cadena de conexi�n a la base de datos en BackEnd/Conexion.css
4. Compila y ejecuta el proyecto.

## Uso

1. Inicia sesi�n como usuario o administrador.
2. Como **usuario**, puedes:
- Revisar tus notificaciones
- Configurar secciones personalizadas
- Entrar a un grupo con un c�digo de grupo
3. Como **administrador**, puedes:
- Crear y enviar notificaciones
- Administrar usuarios, grupos y secciones

## Licencia

me vale verga w haz lo que quieras pero no me demandes.

## Autor

Desarrollado por [Nope79].