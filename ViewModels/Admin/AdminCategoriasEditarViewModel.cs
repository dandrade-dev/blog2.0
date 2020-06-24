﻿using PWABlog.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PWABlog.ViewModels.Admin.AdminCategoriasCriarViewModel;

namespace PWABlog.ViewModels.Admin
{
    public class AdminCategoriasEditarViewModel : ViewModelAreaAdministrativa
    {
        public int IdCategoria { get; set; }
        public string Erro { get; set; }

        public string NomeCategoria { get; set; }

        public int IdEtiquetaCategoria { get; set; }
        public int IdPostagensCategoria { get; set; }
        public ICollection<EtiquetasAdminCategorias> Etiquetas { get; set; }

        public ICollection<PostagensAdminCategorias> Postagens { get; set; }


        public AdminCategoriasEditarViewModel()
        {
            TituloPagina = "Criar novaCategoria";
            Etiquetas = new List<EtiquetasAdminCategorias>();
            Postagens = new List<PostagensAdminCategorias>();
        }
    }
}
