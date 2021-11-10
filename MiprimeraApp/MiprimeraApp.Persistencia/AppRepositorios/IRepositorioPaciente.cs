using System;
using System.Collections.Generic;
using MiprimeraApp.Dominio;

namespace MiprimeraApp.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente GetPaciente(int idPaciente);
    }
}