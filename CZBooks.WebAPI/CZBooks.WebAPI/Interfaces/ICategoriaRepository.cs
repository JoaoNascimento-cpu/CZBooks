using CZBooks.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.WebAPI.Interfaces
{
    interface ICategoriaRepository
    {
        List<Categoria> Listar();

        /// <summary>
        /// método utilizado para buscr um usuário existente
        /// </summary>
        /// <param name="id">id do usuário que irá passar pela url da requisição</param>
        /// <returns>usuário buscado</returns>
        Categoria BuscarPorId(int id);

        /// <summary>
        /// método utilizado para cadastrar um novo usuário
        /// </summary>
        /// <param name="NovoUsuario">objeto que irá armazenar as informações do novo usuário cadastrado</param>
        void Cadastro(Categoria NovaCategoria);

        void Deletar(int id);

        /// <summary>
        /// método utilizado para atualizar determinado usuário
        /// </summary>
        /// <param name="id">id do usuário buscado</param>
        /// <param name="usuario">objeto que irá armazenar as novas informações do usuário</param>
        void AtualizarCategoria(int id, Categoria categoria);
    }
}
