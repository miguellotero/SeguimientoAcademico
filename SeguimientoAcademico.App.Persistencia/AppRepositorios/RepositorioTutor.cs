using SeguimientoAcademico.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace SeguimientoAcademico.App.Persistencia
{
    
    public class RepositorioTutor:IRepositorioTutor
    {
        private readonly AppContext _appContext = new AppContext();

        public RepositorioTutor(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Tutor IRepositorioTutor.AddTutor(Tutor tutor)
        {
            var tutorAdicionado= _appContext.Tutores.Add(tutor);
            _appContext.SaveChanges();
            return tutorAdicionado.Entity;
        }

        void IRepositorioTutor.DeleteTutor(int IdTutor)
        {
            var tutorEncontrado = _appContext.Tutores.Find(IdTutor);
            if(tutorEncontrado == null){
                return;
            }
            _appContext.Tutores.Remove(tutorEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Tutor> IRepositorioTutor.GetAllTutors()
        {
            return _appContext.Tutores;
        }

        Tutor IRepositorioTutor.GetTutor(int IdTutor)
        {
            return _appContext.Tutores.Find(IdTutor);
        }

        Tutor IRepositorioTutor.UpdateTutor(Tutor tutor)
        {
            var tutorEncontrado=_appContext.Tutores.Find(tutor.Id);
            if(tutorEncontrado != null)
            {
                tutorEncontrado.Nombre=tutor.Nombre;
                tutorEncontrado.Apellido=tutor.Apellido;
                tutorEncontrado.Telefono=tutor.Telefono;
                tutorEncontrado.genero=tutor.genero; 
                tutorEncontrado.Escolaridad=tutor.Escolaridad;
                _appContext.SaveChanges();
            }
            return tutorEncontrado;
        }

    }
}
