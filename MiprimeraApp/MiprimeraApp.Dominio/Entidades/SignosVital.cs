namespace MiprimeraApp.Dominio.Entidades
{
    public class SignosVital
    {
        public int Id {get; set;}
        public DateTime FechaHora {get;set;}
        public Float Valor {get;set;}
        public TipoSigno Signo {get;set;}
        public Paciente Paciente {get;set;}

    }
}