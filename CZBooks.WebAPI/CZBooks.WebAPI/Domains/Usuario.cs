using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CZBooks.WebAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Autores = new HashSet<Autore>();
            Livros = new HashSet<Livro>();
        }

        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "Escreva o id do tipo de usuário deste usuário ")]
        public int? IdTipoUsuario { get; set; }
        [Required(ErrorMessage = "Escreva o email deste usuário")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Escreva a senha deste usuário")]
        public string Senha { get; set; }

        public virtual TiposUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Autore> Autores { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
