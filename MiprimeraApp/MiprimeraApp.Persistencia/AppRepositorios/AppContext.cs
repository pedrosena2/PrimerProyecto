using Microsoft.EntityFrameworkCore;
using MiprimeraApp.Dominio;



namespace MiprimeraApp.Persistencia

{   
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Paciente> Pacientes {get;set;}
        public DbSet<Medico> Medicos {get;set;}
        public DbSet<SignoVital> SignosVitales {get;set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Initial Catalog=Hospital220708; Data Source=LAPTOP-14PD7JPN; Integrated Security=true");
                /*
                initial catalog: nombre de la base de datos
                data source:nombre del servidore de la base de datos
                integrated security: seguridad con la mismaconfiguracion del inicio de sesion
                */
            }

        }
    }
}