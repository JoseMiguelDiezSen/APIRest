using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIRestCore.Entities;
using APIRestCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace APIRestCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Usuarios usuarios = new Usuarios();
            return Ok(usuarios.ObtenerUsuarios());
        }

        // READ
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Usuarios usuarios = new Usuarios();
            var usuario = usuarios.ObtenerUsuario(id);

            if (usuario == null)
            {
                var notFound = NotFound("El usuario " + id.ToString() + " no existe.");
                return notFound;
            }

            return Ok(usuario);
        }

        // CREATE
        [HttpPost("Añadir")]
        [SwaggerOperation(Summary = "Añade un usuario a la base de datos", Description = "Gets two hardcoded values")]
        public IActionResult AgregarUsuario(Usuario nuevoUsuario)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Agregar(nuevoUsuario);
            return CreatedAtAction(nameof(AgregarUsuario), nuevoUsuario);
        }

        // UPDATE
        [HttpPut("Actualizar")]
        [SwaggerOperation(Summary = "Actualiza un usuario de la base de datos", Description = "Gets two hardcoded values")]
        public IActionResult ActualizarUsuario(Usuario nuevoUsuario)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Agregar(nuevoUsuario);
            return CreatedAtAction(nameof(AgregarUsuario), nuevoUsuario);
        }

        // DELETE
        [HttpDelete("Eliminar")]
        [SwaggerOperation(Summary = "Elimina un usuario de la base de datos", Description = "Gets two hardcoded values")]
        public IActionResult EliminarUsuario(int id)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Eliminar(id);
            return CreatedAtAction(nameof(AgregarUsuario), id);
        }
    }
}