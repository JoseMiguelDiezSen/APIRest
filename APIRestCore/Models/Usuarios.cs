using APIRestCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIRestCore.Models
{
    public class Usuarios
    {
        public static List<Usuario> _listaUsuarios = new List<Usuario>()
        {
            new Usuario() { Id = 1, Nombre = "Cliente 1" , Apellido = "Apellido 1" },
            new Usuario() { Id = 2, Nombre = "Cliente 2" , Apellido = "Apellido 2" },
            new Usuario() { Id = 3, Nombre = "Cliente 3" , Apellido = "Apellido 3" }
        };

        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            return _listaUsuarios;
        }
        
        public Usuario ObtenerUsuario(int id)
        {
            var usuario = _listaUsuarios.Where(user => user.Id == id);
            return usuario.FirstOrDefault();
        }
        
        public void Agregar(Usuario nuevoUsuario)
        {
            _listaUsuarios.Add(nuevoUsuario);
        }

        public void Actualizar(int id)
        {

        }

        public void Eliminar(int id)
        {
            _listaUsuarios.RemoveAt(id);
        }

    }
}

