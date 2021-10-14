using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeguimientoAcademico.App.Dominio;
using SeguimientoAcademico.App.Persistencia;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SeguimientoAcademico.App.Presentacion.Pages.Estudiantes
{
    public class ConsultarEstudiantesModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public IEnumerable<Estudiante> estudiantes{get;set;}
        public ConsultarEstudiantesModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante=_repoEstudiante;
        }
        
        public void OnGet()
        {
            estudiantes=_repoEstudiante.GetAllEstudiantes();
        }
    }
}
