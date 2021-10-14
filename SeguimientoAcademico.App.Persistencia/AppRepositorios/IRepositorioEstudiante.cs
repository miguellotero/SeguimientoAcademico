using SeguimientoAcademico.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace SeguimientoAcademico.App.Persistencia
{
    public interface IRepositorioEstudiante
    {
        IEnumerable<Estudiante> GetAllEstudiantes();
        Estudiante AddEstudiante(Estudiante estudiante);
        Estudiante UpdateEstudiante(Estudiante estudiante);
        void DeleteEstudiante(int IdEstudiante);
        Estudiante GetEstudiante(int IdEstudiante);
        void AddActividad(int IdEstudiante, Actividad actividad);
        //IEnumerable<Estudiante> GetEstudiantesTaller();
    }
}
