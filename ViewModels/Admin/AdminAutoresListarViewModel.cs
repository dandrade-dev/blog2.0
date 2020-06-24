using PWABlog.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWABlog.ViewModels.Admin
{
    public class AdminAutoresListarViewModel : ViewModelAreaAdministrativa
    {
        public ICollection<AutoresAdminAutores> Autores { get; set; }
        public AdminAutoresListarViewModel()
        {
            TituloPagina = "Autores - Administrador";
        }
       
    }
    public class AutoresAdminAutores
    {
        public int Id { get; set; }
        public string Nome { get; set; }

    }
}
