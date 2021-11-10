using System;
using System.Collections.Generic;
using MiprimeraApp.Dominio;
using MiprimeraApp.Persistencia;

namespace MiprimeraApp.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al 5 noviembre!");
            AddPaciente();
            //BuscarPaciente(2);
             //MostrarPacientes(); 
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre="Valentina",
                Apellidos="Garzon",
                NumeroTelefono="6068844433",
                Genero=Genero.Femenino,
                Direccion="Calle 67 no 11-84",
                Ciudad="Manizales",
                FechaNacimiento= new DateTime(1985,07,30)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void MostrarPacientes()
        {
            IEnumerable <Paciente> pacientes = _repoPaciente.GetAllPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente.Nombre+" "+ paciente.Apellidos+" "+paciente.Genero); 
            }
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Id+" "+paciente.Nombre+" "+paciente.Apellidos+" "+paciente.Genero);
        }

    }
}
