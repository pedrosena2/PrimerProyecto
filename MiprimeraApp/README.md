TUTORIAL INICIAL asp.net core 5.0

dotnet run: Ejecutar el programa
dotnet build: Para compilar y revisar errores
dotnet --version: Para revisar la version del sdk de .net

1) Descargar e instalar .net core 5.0 https://dotnet.microsoft.com/download

2) Instalar Visual Studio Code
        Instalar extensiones:
                 C# For Microsoft
                 C# Extension jchannon
                 C# Extension Joskreativ

3) Se debe instalar el Framework Entity de forma global.
        a) dotnet tool install --global dotnet-ef (instalacion del entity Framework)
        b) dotnet tool update --global dotnet-ef (actualizacion del entity Framework) 

4) Instalar la solucion de Entity Framework (el programa que se va a construir)     
        (MiprimeraApp es el nombre del programa a construir)
        dotnet new sln -oMiprimeraApp

5) Instalar las libretas para generar la conexion con la base de datos e implementar las entidades del programa.
        a) dotnet new classlib-o MiprimeraApp.Persistencia 
        b) dotnet new classlib-o MiprimeraApp.Dominio

6) Instalar la aplicacion web para crear el frotend del programa
        a) dotnet new webapp -o MiprimeraApp.frontend del programa

7) Instalarla libreria de consola para realizar prueba del programa
        a) dotnet new console -o MiprimeraApp.Consola

8) Instalacion de paquetes:
        dotnet add package Microsoft.EntityFrameworkCore --version 5.0.9 (opcion para instalaruna version especifica)
        dotnet add package Microsoft.EntityFrameworkCore
        dotnet add package Microsoft.EntityFrameworkCore.Tools
        dotnet add package Microsoft.EntityFrameworkCore.Design
        dotnet add package Microsoft.EntityFrameworkCore.SqlServer

        a) Carpeta Consola
                    dotnet add package Microsoft.EntityFrameworkCore.Design

        b) Carpeta Frontend

        c) Carpeta Persistencia
                    dotnet add package Microsoft.EntityFrameworkCore
                    dotnet add package Microsoft.EntityFrameworkCore.Tools
                    dotnet add package Microsoft.EntityFrameworkCore.Design
                    dotnet add package Microsoft.EntityFrameworkCore.SqlServer

9) crear las referncias a las carpetas de persistencia y dominio; siempre y cuando analicemos que uniones debemos realizar dentro  de los .csproj

                        dotnet add reference ..\MiprimeraApp.Dominio     
                                a)Carpeta Consola referencia a Persistencia y Dominio
                                b)Carpeta Persistencia a Dominio

10) Crear las entidades en la carpeta Dominio

11) Crear el AppContext para realizar el mapeo de las entidades para crear la migracion y crear la conexion con la base de datos (SQL SERVER)

12) Crear la migracion a la base de datos
    12.1) Si no tiene migraciones.
        a) dotnet ef database Inicial --startup-project ..\MiprimeraApp.Consola\
    
    12.2) Si ya existe  migraciones
        b) dotnet ef database update --startup-project ..\MiprimeraApp.Consola\