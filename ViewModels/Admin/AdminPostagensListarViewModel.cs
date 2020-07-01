using PWABlog.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWABlog.ViewModels.Admin
{
    public class AdminPostagensListarViewModel : ViewModelAreaAdministrativa
    {
        public ICollection<PostagemAdminPostagens> Postagens { get; set; }

        public AdminPostagensListarViewModel()
        {
            TituloPagina = "Postagens - Administrador";
            Postagens = new List<PostagemAdminPostagens>();
        }
    }
    public class PostagemAdminPostagens
    {
        public int IdPostagem { get; set; }

        public string NomePostagem { get; set; }

        public string DescricaoPostagem { get; set; }

        public DateTime DataPostagem { get; set; }

        public string NomeCategorias { get; set; }

        public string NomeAutores { get; set; }
    }
}
