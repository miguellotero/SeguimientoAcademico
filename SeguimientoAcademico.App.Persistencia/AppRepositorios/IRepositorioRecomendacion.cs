using SeguimientoAcademico.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace SeguimientoAcademico.App.Persistencia
{
    public interface IRepositorioRecomendacion
    {
        IEnumerable<Recomendacion> GetAllRecomendacion();
        Recomendacion AddRecomendacion(Recomendacion recomendacion);
        Recomendacion UpdateRecomendacion(Recomendacion recomendacion);
        void DeleteRecomendacion(int IdRecomendacion);
        Recomendacion GetRecomendacion(int IdRecomendacion);
    }
}
