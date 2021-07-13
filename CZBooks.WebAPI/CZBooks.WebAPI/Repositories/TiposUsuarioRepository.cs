using CZBooks.WebAPI.Contexts;
using CZBooks.WebAPI.Domains;
using CZBooks.WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.WebAPI.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        CZBctx ctx = new CZBctx();

        public void Atualizar(int id, TiposUsuario novoTipoUsuario)
        {
            TiposUsuario tipoUsuarioBuscado = ctx.TiposUsuarios.Find(id);

            if (tipoUsuarioBuscado.TituloTipoUsuario != null)
            {
                tipoUsuarioBuscado.TituloTipoUsuario = novoTipoUsuario.TituloTipoUsuario;
            }

            ctx.TiposUsuarios.Update(tipoUsuarioBuscado);
            ctx.SaveChanges();
        }

        public TiposUsuario BuscarPorId(int id)
        {
            return ctx.TiposUsuarios.FirstOrDefault(u => u.IdTipoUsuario == id);
        }

        public void Cadastro(TiposUsuario novoTipoUsuario)
        {
            ctx.Add(novoTipoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TiposUsuario tipoUsuarioBuscado = ctx.TiposUsuarios.Find(id);
            ctx.TiposUsuarios.Remove(tipoUsuarioBuscado);
            ctx.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            return ctx.TiposUsuarios.ToList();
        }
    }
}
