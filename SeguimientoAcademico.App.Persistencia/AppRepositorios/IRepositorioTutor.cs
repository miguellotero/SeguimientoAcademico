using SeguimientoAcademico.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace SeguimientoAcademico.App.Persistencia
{
    public interface IRepositorioTutor
    {
        IEnumerable<Tutor> GetAllTutors();
        Tutor AddTutor(Tutor tutor);
        Tutor UpdateTutor(Tutor tutor);
        void DeleteTutor(int IdTutor);
        Tutor GetTutor(int IdTutor);
    }
}
