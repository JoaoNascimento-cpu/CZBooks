using CZBooks.WebAPI.Contexts;
using CZBooks.WebAPI.Domains;
using CZBooks.WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.WebAPI.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        CZBctx ctx = new CZBctx();

        public void AtualizarCategoria(int id, Categoria categoria)
        {
            Categoria categoriaBuscada = ctx.Categorias.Find(id);

            if (categoria.Categoria1 != null)
            {
                categoriaBuscada.Categoria1 = categoria.Categoria1;
            }

            ctx.Categorias.Update(categoriaBuscada);
            ctx.SaveChanges();
        }

        public Categoria BuscarPorId(int id)
        {
            return ctx.Categorias.FirstOrDefault(c => c.IdCategoria == id);
        }

        public void Cadastro(Categoria NovaCategoria)
        {
            ctx.Categorias.Add(NovaCategoria);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Categoria categoriaBuscada = ctx.Categorias.Find(id);
            ctx.Categorias.Remove(categoriaBuscada);
            ctx.SaveChanges();
        }

        public List<Categoria> Listar()
        {
            return ctx.Categorias.ToList();
        }
    }
}
