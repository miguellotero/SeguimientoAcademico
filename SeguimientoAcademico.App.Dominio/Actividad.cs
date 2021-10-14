using System;
using SegumientoAcademico.App.Dominio;

namespace SeguimientoAcademico.App.Dominio
{

    public class Actividad
    {
        public int Id {get;set;}
        public string Nombre {get; set;}
        public string Descripcion {get; set;}
        public Avance Avance {get; set;}       


    }
    
}