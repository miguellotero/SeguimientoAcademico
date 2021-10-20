
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguimientoAcademico.App.Persistencia;
using SeguimientoAcademico.App.Dominio;

namespace SeguimientoAcademico.App.Presentacion.Pages.Estudiantes
{
    
    public class ActividadModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;     

        public Estudiante estudiante{get;set;}
        public Actividad actividad{get;set;}
        public ActividadModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante=_repoEstudiante;
        }

        
        public IActionResult OnGet(int id)
        {
            estudiante=_repoEstudiante.GetEstudiante(id);
            if(estudiante != null)
            {
                return Page();
            }else
            {
                return NotFound();
            }
        }
        public IActionResult OnPost(int Id, Actividad actividad)
        {
            _repoEstudiante.AddActividad(Id,actividad);
            return RedirectToPage("ConsultarEstudiantes");
        }
        
    }
}
