using CZBooks.WebAPI.Contexts;
using CZBooks.WebAPI.Domains;
using CZBooks.WebAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.WebAPI.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        CZBctx ctx = new CZBctx();
        public void Atualizar(int id, Livro novoLivro)
        {
            Livro livroBuscado = ctx.Livros.Find(id);

            if (novoLivro.Titulo != null)
            {
                livroBuscado.Sinopse = livroBuscado.Sinopse;
            }

            ctx.Livros.Update(livroBuscado);
            ctx.SaveChanges();
        }

        public Livro BuscarId(int id)
        {
            return ctx.Livros.FirstOrDefault(c => c.IdLivro == id);
        }

        public void Cadastrar(Livro novoLivro)
        {
            ctx.Livros.Add(novoLivro);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Livro livroBuscado = ctx.Livros.Find(id);
            ctx.Livros.Remove(livroBuscado);
            ctx.SaveChanges();
        }

        public List<Livro> ListarTudo()
        {
            return ctx.Livros.ToList();
        }

        public List<Livro> LivrosAutor(int id)
        {
            Livro livroBuscado = ctx.Livros.FirstOrDefault(i => i.IdLivro == id);

            return ctx.Livros
               .Include(t => t.IdInstituicaoNavigation)
               .Include(s => s.NomeAutor)
               .Where(m => m.IdLivro == livroBuscado.IdLivro)
               .ToList();
        }
    }
}
