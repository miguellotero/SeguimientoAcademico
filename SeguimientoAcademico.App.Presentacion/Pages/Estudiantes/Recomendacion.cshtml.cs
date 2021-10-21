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
    public class RecomendacionModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;     

        public Estudiante estudiante{get;set;}
        public Recomendacion recomendacion{get;set;}
        public RecomendacionModel(IRepositorioEstudiante _repoEstudiante)
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
        public IActionResult OnPost(int Id, Recomendacion recomendacion)
        {
            _repoEstudiante.AddRecomendacion(Id,recomendacion);
            return RedirectToPage("ConsultarEstudiantes");
        }
    }
}
