using System;
using System.Collections.Generic;

#nullable disable

namespace CZBooks.WebAPI.Domains
{
    public partial class Instituico
    {
        public Instituico()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdInstituicao { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cnpj { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
