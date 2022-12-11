using SlnAppBlogCoreProyect.AccesoDatos.Data.Repository.IRepository;
using SlnAppBlogCoreProyect.Data;
using SlnAppBlogCoreProyect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SlnAppBlogCoreProyect.AccesoDatos.Data.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoriaRepository(ApplicationDbContext db): base(db) 
        {
            _db= db;
        }

        public IEnumerable<SelectListItem> GetListaCategorias()
        {
            return _db.Categoria.Select(i => new SelectListItem()
            {
                Text= i.Nombre,
                Value = i.Id.ToString(),
            }

            );
            
        }

        public void Update(Categoria categoria)
        {
            var objetoDesdeDB = _db.Categoria.FirstOrDefault(s => s.Id == categoria.Id);
            objetoDesdeDB.Nombre= categoria.Nombre;
            objetoDesdeDB.Orden=categoria.Orden;
            _db.SaveChanges();
        }
    }
}
