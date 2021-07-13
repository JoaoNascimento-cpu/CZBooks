using CZBooks.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.WebAPI.Interfaces
{
    interface ILivroRepository
    {
        List<Livro> ListarTudo();
        List<Livro> LivrosAutor(int id);
        Livro BuscarId(int id);
        void Cadastrar(Livro novoLivro);
        void Deletar(int id);
        void Atualizar(int id, Livro novoLivro);
    }
}
