using SeguimientoAcademico.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace SeguimientoAcademico.App.Persistencia
{
    public interface IRepositorioMaterias
    {
        IEnumerable<Materia> GetAllMateria();
        Materia AddMateria(Materia materia);
        Materia UpdateMateria(Materia materia);
        void DeleteMateria(int IdMateria);
        Materia GetMateria(int IdMateria);
    }
}
