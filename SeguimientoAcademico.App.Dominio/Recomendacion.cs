using System;
using SegumientoAcademico.App.Dominio;

namespace SeguimientoAcademico.App.Dominio
{

    public class Recomendacion
    {
        public int Id {get;set;}
        public string Nombre {get; set;}
        public Sugerencia sugerencia {get;set;} 
        
    }
    
}