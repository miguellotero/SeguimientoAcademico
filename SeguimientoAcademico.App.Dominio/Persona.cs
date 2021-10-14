using System;
using SegumientoAcademico.App.Dominio;

namespace SeguimientoAcademico.App.Dominio
{

    public class Persona
    {
        public int Id {get;set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}

        public string Telefono {get; set;}
        
        public Genero genero {get;set;} 
        


    }
    
}