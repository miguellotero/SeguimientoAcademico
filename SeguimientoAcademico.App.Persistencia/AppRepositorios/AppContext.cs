using Microsoft.EntityFrameworkCore;
using SeguimientoAcademico.App.Dominio;
namespace SeguimientoAcademico.App.Persistencia
{
    public class AppContext:DbContext
    {    
        
        public DbSet <Persona> Personas {get;set;} 
        public DbSet <Estudiante> Estudiantes {get;set;} 
        public DbSet <Maestro> Maestros {get;set;} 
        public DbSet <FamiliarDesignado> FamiliarDesignados {get;set;} 
        public DbSet <Tutor> Tutores {get;set;} 
        public DbSet <Materia> Materias {get;set;} 
        public DbSet <Actividad> Actividades {get;set;} 
        public DbSet <Recomendacion> Recomendaciones {get;set;} 
         
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {

            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog=SeguimientoAcademico.Data");    

            }

        }
    }

    }
