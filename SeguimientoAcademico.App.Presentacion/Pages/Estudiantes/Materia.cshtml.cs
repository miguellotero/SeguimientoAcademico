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
    public class MateriaModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;     

        public Estudiante estudiante{get;set;}
        public Materia materia{get;set;}

        public MateriaModel(IRepositorioEstudiante _repoEstudiante)
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
        public IActionResult OnPost(int Id,Materia materia)
        {
            _repoEstudiante.AddMaterias(Id,materia);
            return RedirectToPage("ConsultarEstudiantes");
        }
    }
}
