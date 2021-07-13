using CZBooks.WebAPI.Domains;
using CZBooks.WebAPI.Interfaces;
using CZBooks.WebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZBooks.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private ICategoriaRepository categoria { get; set; }

        public CategoriaController()
        {
            categoria = new CategoriaRepository();
        }

        [HttpGet]
        //http://5000/api/TipoUsuario
        public IActionResult Listar()
        {
            try
            {
                return Ok(categoria.Listar());
            }
            catch (Exception exception)
            {

                return BadRequest(exception);
            }
        }

        [HttpGet("{id}")]
        //http://5000/api/usuario
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                return Ok(categoria.BuscarPorId(id));
            }
            catch (Exception excepition)
            {
                return BadRequest(excepition);
            }
        }

        [HttpPost]
        public IActionResult Cadastro(Categoria novaCategoria)
        {
            try
            {
                categoria.Cadastro(novaCategoria);
                return StatusCode(201);
            }
            catch (Exception exception)
            {

                return BadRequest(exception);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                categoria.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception exception)
            {

                return BadRequest(exception);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Categoria novaCategoria)
        {
            try
            {
                categoria.AtualizarCategoria(id, novaCategoria);
                return StatusCode(204);
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }
    }
}
