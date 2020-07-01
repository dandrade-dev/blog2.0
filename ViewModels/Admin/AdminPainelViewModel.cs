using PWABlog.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWABlog.ViewModels.Admin
{
    public class AdminPainelViewModel : ViewModelAreaAdministrativa
    {
        public string Erro { get; set; }

        public ICollection<CategoriasAdminPainel> Categorias { get; set; }
        public ICollection<AutoresAdminPainel> Autores { get; set; }
        public ICollection<EtiquetasAdminPainel> Etiquetas { get; set; }
        public ICollection<PostagensAdminPainel> Postagens { get; set; }


        public AdminPainelViewModel()
        {
            TituloPagina = "Painel - Administrador";
            Categorias = new List<CategoriasAdminPainel>();
            Autores   = new List<AutoresAdminPainel>();
            Etiquetas = new List<EtiquetasAdminPainel>();
            Postagens = new List<PostagensAdminPainel>();
        }        
    }
    public class AutoresAdminPainel
    {
        public int IdAutores { get; set; }
    }
    public class CategoriasAdminPainel
    {
        public int IdCategorias { get; set; }
    }
    public class EtiquetasAdminPainel
    {
        public int IdEtiquetas { get; set; }
    }
    public class PostagensAdminPainel
    {
        public int IdPostagens { get; set; }
    }
}
