﻿using PWABlog.Models.Blog.Autor;
using PWABlog.Models.Blog.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWABlog.RequestModels.AdminPostagem
{
    public class AdminPostagemCriarRequestModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public AutorEntity Autor { get; set; }
        public CategoriaEntity Categoria { get; set; }
    }
}
