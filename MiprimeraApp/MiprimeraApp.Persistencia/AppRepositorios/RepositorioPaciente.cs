using System.Collections.Generic;
using System.Linq;
using MiprimeraApp.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MiprimeraApp.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext= new AppContext(); 

       public Paciente AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity; 
        }
        public IEnumerable<Paciente> GetAllPacientes()
        {
            return _appContext.Pacientes;
        }
        public Paciente GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.Find(idPaciente);
            
        }

    }
}