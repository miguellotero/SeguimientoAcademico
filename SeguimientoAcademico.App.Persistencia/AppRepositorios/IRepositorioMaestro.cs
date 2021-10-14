using SeguimientoAcademico.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace SeguimientoAcademico.App.Persistencia
{
    public interface IRepositorioMaestro
    {
        IEnumerable<Maestro> GetAllMaestros();
        Maestro AddMaestro(Maestro maestro);
        Maestro UpdateMaestro(Maestro Maestro);
        void DeleteMaestro(int IdMaestro);
        Maestro GetMaestro(int IdMaestro);
    }
}
