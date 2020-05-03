using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWABlog.Models.Blog.Autor
{
    public class AutorOrmService
    {
        private readonly DatabaseContext _databaseContext;

       public AutorOrmService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public List<AutorEntity> ObterAutor()
        {
            return _databaseContext.Autores.ToList();
        }
    }
}
