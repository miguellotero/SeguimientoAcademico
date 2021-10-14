using SeguimientoAcademico.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace SeguimientoAcademico.App.Persistencia
{
    
    public class RepositorioEstudiante:IRepositorioEstudiante
    {
        private readonly AppContext _appContext = new AppContext();

        /*public RepositorioEstudiante(AppContext appContext)
        {
            _appContext=appContext;
        }*/
        
        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var estudianteAdicionado= _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteAdicionado.Entity;
        }

        void IRepositorioEstudiante.DeleteEstudiante(int IdEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.Find(IdEstudiante);
            if(estudianteEncontrado == null){
                return;
            }
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return _appContext.Estudiantes;
        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int IdEstudiante)
        {
            return _appContext.Estudiantes.Find(IdEstudiante);
        }

        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudianteEncontrado=_appContext.Estudiantes.Find(estudiante.Id);
            if(estudianteEncontrado != null)
            {
                estudianteEncontrado.Nombre=estudiante.Nombre;
                estudianteEncontrado.Apellido=estudiante.Apellido;
                estudianteEncontrado.Telefono=estudiante.Telefono;
                estudianteEncontrado.genero=estudiante.genero; 
                estudianteEncontrado.Direccion=estudiante.Direccion;
                estudianteEncontrado.Latitud=estudiante.Latitud;
                estudianteEncontrado.Longitud=estudiante.Longitud;
                _appContext.SaveChanges();
            }
            return estudianteEncontrado;
        }
        void IRepositorioEstudiante.AddActividad(int IdEstudiante, Actividad actividad)
        {
            var estudiante=_appContext.Estudiantes.Find(IdEstudiante);
            if(estudiante != null)
            {
                if(estudiante.Actividades != null)
                {
                    estudiante.Actividades.Add(actividad);
                }else
                {
                    estudiante.Actividades = new List<Actividad>();
                    estudiante.Actividades.Add(actividad); 
                }
                var estudianteEncontrado=_appContext.Estudiantes.Find(estudiante.Id);
                if(estudianteEncontrado != null)
                {
                    estudianteEncontrado.Nombre=estudiante.Nombre;
                    estudianteEncontrado.Apellido=estudiante.Apellido;
                    estudianteEncontrado.Telefono=estudiante.Telefono;
                    estudianteEncontrado.genero=estudiante.genero; 
                    estudianteEncontrado.Direccion=estudiante.Direccion;
                    estudianteEncontrado.Latitud=estudiante.Latitud;
                    estudianteEncontrado.Longitud=estudiante.Longitud;
                    _appContext.SaveChanges();
                }

                
            }
        }

        /*IEnumerable<Estudiante> IRepositorioEstudiante.GetEstudiantesTaller()
        {
            return _appContext.Estudiantes.Where(p => p.Actividades.Any(a => Actividad.Nombre == "Taller")).ToList();
        }*/

    }
}
