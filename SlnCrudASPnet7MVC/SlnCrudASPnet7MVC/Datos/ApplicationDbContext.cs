using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SlnCrudASPnet7MVC.Models;

namespace SlnCrudASPnet7MVC.Datos
{

   public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {

        }
        // Agregaremos los modelos
        public DbSet<Contacto> Contacto { get; set; }  
        
    }
}
