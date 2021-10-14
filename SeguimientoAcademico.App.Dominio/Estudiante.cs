using System.Collections.Generic;

namespace SeguimientoAcademico.App.Dominio
{
    public class Estudiante:Persona
    {
        public string Direccion{get;set;}
        public string Latitud{get;set;}
        public string Longitud{get;set;}
        public List<Materia> Materias {get;set;}
        public FamiliarDesignado FamiliarDesignado {get;set;}
        public List<Maestro> Maestros{get;set;}
        public List<Actividad> Actividades{get;set;}
        public List<Recomendacion> Recomendaciones {get;set;}

    }
}