
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
        /*public Actividad actividad{get;set;}    
        public ActividadModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante=_repoEstudiante;
        }
        */
        public void OnGet(int IdEstudiante)
        {
            /*estudiante=_repoEstudiante.GetEstudiante(IdEstudiante);
            if(estudiante != null)
            {
                return Pages();
            }else
            {
                return NotFound();
            }*/
        }
        /*public IActionResult OnPost(int IdEstudiante, Actividad actividad)
        {
            _repoEstudiante.AddActividad(IdEstudiante,actividad);
            return RedirectToPage("ConsultarEstudiantes");
        }
        */
    }
}
