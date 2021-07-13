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
    public class TiposUsuarioController : ControllerBase
    {
        private ITiposUsuarioRepository tipoUsuario { get; set; }

        public TiposUsuarioController()
        {
            tipoUsuario = new TiposUsuarioRepository();
        }

        [HttpGet]
        //http://5000/api/TipoUsuario
        public IActionResult Listar()
        {
            try
            {
                return Ok(tipoUsuario.Listar());
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
                return Ok(tipoUsuario.BuscarPorId(id));
            }
            catch (Exception excepition)
            {
                return BadRequest(excepition);
            }
        }

        [HttpPost]
        public IActionResult Cadastro(TiposUsuario novoTipoUsuario)
        {
            try
            {
                tipoUsuario.Cadastro(novoTipoUsuario);
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
                tipoUsuario.Deletar(id);
                return StatusCode(204);
            }
            catch (Exception exception)
            {

                return BadRequest(exception);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, TiposUsuario novoUsuario)
        {
            try
            {
                tipoUsuario.Atualizar(id, novoUsuario);
                return StatusCode(204);
            }
            catch (Exception exception)
            {
                return BadRequest(exception);
            }
        }
    }
}
