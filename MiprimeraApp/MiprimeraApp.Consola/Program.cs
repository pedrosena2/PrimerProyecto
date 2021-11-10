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
            //AddPaciente();
            //BuscarPaciente(1);
            //MostrarPaciente(); 
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre="Pepito",
                Apellidos="Perez",
                NumeroTelefono="6068888888",
                Genero=Genero.Masculino,
                Direccion="Calle 10 no 1-2",
                Ciudad="Manizales",
                FechaNacimiento= new DateTime(1990,04,12)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void MostrarPaciente()
        {
            IEnumerable<Paciente> pacientes = _repoPaciente.GetAllPacientes();
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
