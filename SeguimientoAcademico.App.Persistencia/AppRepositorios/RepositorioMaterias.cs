using SeguimientoAcademico.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace SeguimientoAcademico.App.Persistencia
{
    
    public class RepositorioMaterias:IRepositorioMaterias
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioMaterias(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Materia IRepositorioMaterias.AddMateria(Materia materia)
        {
            var materiaAdicionado= _appContext.Materias.Add(materia);
            _appContext.SaveChanges();
            return materiaAdicionado.Entity;
        }

        void IRepositorioMaterias.DeleteMateria(int IdMateria)
        {
            var materiaEncontrado = _appContext.Materias.Find(IdMateria);
            if(materiaEncontrado == null){
                return;
            }
            _appContext.Materias.Remove(materiaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Materia> IRepositorioMaterias.GetAllMateria()
        {
            return _appContext.Materias;
        }

        Materia IRepositorioMaterias.GetMateria(int IdMateria)
        {
            return _appContext.Materias.Find(IdMateria);
        }

        Materia IRepositorioMaterias.UpdateMateria(Materia materia)
        {
            var materiaEncontrado=_appContext.Materias.Find(materia.Id);
            if(materiaEncontrado != null)
            {
                materiaEncontrado.Nombre=materia.Nombre;
                _appContext.SaveChanges();
            }
            return materiaEncontrado;
        }

    }
}
