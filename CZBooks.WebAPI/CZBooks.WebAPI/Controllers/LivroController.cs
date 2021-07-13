using CZBooks.WebAPI.Domains;
using CZBooks.WebAPI.Interfaces;
using CZBooks.WebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private ILivroRepository livro { get; set; }

        public LivroController()
        {
            livro = new LivroRepository();
        }

        [HttpGet]
        //http://5000/api/Consulta
        public IActionResult Listar()
        {
            try
            {
                return Ok(livro.ListarTudo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("ListarTudo")]
        public IActionResult ListarTudo()
        {
            try
            {
                return Ok(livro.ListarTudo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("LivrosAutor")]
        public IActionResult livrosAutor()
        {
            try
            {
                int idUsuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);

                return Ok(livro.LivrosAutor(idUsuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarId(int id)
        {
            try
            {
                return Ok(livro.BuscarId(id));
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }

        
        [HttpPost]
        public IActionResult NovoCon(Livro novoLivro)
        {
            try
            {
                livro.Cadastrar(novoLivro);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                livro.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarDados(int id, Livro novoLivro)
        {
            try
            {
                livro.Atualizar(id, novoLivro);
                return StatusCode(204);
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }
    }
}
