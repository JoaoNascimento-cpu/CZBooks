using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CZBooks.WebAPI.Domains
{
    public partial class Livro
    {
        public int IdLivro { get; set; }

        [Required(ErrorMessage = "É necessário o id da categoria ")]
        public int? IdCategoria { get; set; }

        [Required(ErrorMessage = "É necessário o id da instituição que terá este livro")]
        public int? IdInstituicao { get; set; }

        [Required(ErrorMessage = "É necessário o id do autor que escreveu o livro")]
        public int? IdAutor { get; set; }

        [Required(ErrorMessage = "É necessário um título para o livro")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "É necessário o nome do autor que escreveu este livro")]
        public string NomeAutor { get; set; }
        [Required(ErrorMessage = "É necessário uma sinopse para o livro")]
        public string Sinopse { get; set; }
        [Required(ErrorMessage = "É necessário inserir a categoria do livro")]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "É necessário incluir a data de lançamento do livro")]
        public DateTime DataPublicacao { get; set; }
        [Required(ErrorMessage = "É necessário incluir o preço do livro")]
        public string Preco { get; set; }

        public virtual Autore IdAutorNavigation { get; set; }
        public virtual Usuario IdCategoriaNavigation { get; set; }
        public virtual Instituico IdInstituicaoNavigation { get; set; }
    }
}
