using SeguimientoAcademico.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace SeguimientoAcademico.App.Persistencia
{
    public interface IRepositorioActividad
    {
        IEnumerable<Actividad> GetAllActividad();
        Actividad AddActividad(Actividad actividad);
        Actividad UpdateActividad(Actividad actividad);
        void DeleteActividad(int IdActividad);
        Actividad GetActividad(int IdActividad);
    }
}
