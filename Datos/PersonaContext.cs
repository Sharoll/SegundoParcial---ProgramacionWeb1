using Entidad;
using Microsoft.EntityFrameworkCore;
namespace Datos
{
    public class PersonaContext: DbContext
    {
        public PersonaContext(DbContextOptions options): base(options){
        }
        public DbSet<Persona> Personas {get;set;}
         public DbSet<Pago> Pagos {get;set;}
    }
}