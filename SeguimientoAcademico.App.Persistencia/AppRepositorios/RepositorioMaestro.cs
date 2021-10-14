using SeguimientoAcademico.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace SeguimientoAcademico.App.Persistencia
{
    
    public class RepositorioMaestro:IRepositorioMaestro
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioMaestro(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Maestro IRepositorioMaestro.AddMaestro(Maestro maestro)
        {
            var maestroAdicionado= _appContext.Maestros.Add(maestro);
            _appContext.SaveChanges();
            return maestroAdicionado.Entity;
        }

        void IRepositorioMaestro.DeleteMaestro(int IdMaestro)
        {
            var MaestroEncontrado = _appContext.Maestros.Find(IdMaestro);
            if(MaestroEncontrado == null){
                return;
            }
            _appContext.Maestros.Remove(MaestroEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Maestro> IRepositorioMaestro.GetAllMaestros()
        {
            return _appContext.Maestros;
        }

        Maestro IRepositorioMaestro.GetMaestro(int IdMaestro)
        {
            return _appContext.Maestros.Find(IdMaestro);
        }

        Maestro IRepositorioMaestro.UpdateMaestro(Maestro maestro)
        {
            var maestroEncontrado=_appContext.Maestros.Find(maestro.Id);
            if(maestroEncontrado != null)
            {
                maestroEncontrado.Nombre=maestro.Nombre;
                maestroEncontrado.Apellido=maestro.Apellido;
                maestroEncontrado.Telefono=maestro.Telefono;
                maestroEncontrado.genero=maestro.genero;
                maestroEncontrado.TarjetaProfesional=maestro.TarjetaProfesional;
                _appContext.SaveChanges();
            }
            return maestroEncontrado;
        }

    }
}
