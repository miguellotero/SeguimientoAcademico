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
    public class verMestrosModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante;
        public IEnumerable<Maestro> maestros{get;set;}
        public verMestrosModel(IRepositorioEstudiante _repoEstudiante)
        {
            this._repoEstudiante=_repoEstudiante;
        }
        public void OnGet()
        {
            maestros=_repoEstudiante.GetAllMaestro();
        }
    }
}
