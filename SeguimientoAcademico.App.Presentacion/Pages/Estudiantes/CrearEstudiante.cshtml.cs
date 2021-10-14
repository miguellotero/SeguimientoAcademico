using System;
using System.Collections.Generic;
using SeguimientoAcademico.App.Persistencia;
using SeguimientoAcademico.App.Dominio;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SeguimientoAcademico.App.Presentacion.Pages.Estudiantes
{
    public class CrearEstudianteModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public Estudiante estudiante{get;set;}
        public CrearEstudianteModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante=_repoEstudiante;
        }
        public void OnGet()
        {
            estudiante = new Estudiante();
        }
        public void OnPost(Estudiante estudiante)
        {
            _repoEstudiante.AddEstudiante(estudiante);
        }
    }
}
