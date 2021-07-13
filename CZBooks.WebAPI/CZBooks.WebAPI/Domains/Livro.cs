using System;
using System.Collections.Generic;

#nullable disable

namespace CZBooks.WebAPI.Domains
{
    public partial class Livro
    {
        public int IdLivro { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdInstituicao { get; set; }
        public int? IdAutor { get; set; }
        public string Titulo { get; set; }
        public string NomeAutor { get; set; }
        public string Sinopse { get; set; }
        public string Categoria { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Preco { get; set; }

        public virtual Autore IdAutorNavigation { get; set; }
        public virtual Usuario IdCategoriaNavigation { get; set; }
        public virtual Instituico IdInstituicaoNavigation { get; set; }
    }
}
