using NoticieroApi.Models;
using NoticieroApi.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticieroApi.Services
{
    public class UsuarioService
    {
        public readonly NoticieroDbContext _UsuarioDB;
        public UsuarioService(NoticieroDbContext UsuarioDB)
        {
            _UsuarioDB = UsuarioDB;
        }

        public List<Usuario> VerUsuario()
        {
            var UsuarioBuscado = _UsuarioDB.Usuario.OrderByDescending(x => x.IdUsuario).ToList();
            return UsuarioBuscado;
        }

        public bool Agregar(Usuario UsuarioAgregar)
        {
            try
            {
                _UsuarioDB.Usuario.Add(UsuarioAgregar);
                _UsuarioDB.SaveChanges();
                return true;

            }
            catch (Exception error)
            {
                return false;

            }

        }

        public bool Editar(Usuario UsuarioEditar)
        {
            try
            {
                var Usuario = _UsuarioDB.Usuario.FirstOrDefault(x => x.IdUsuario == UsuarioEditar.IdUsuario);
                Usuario.alias = UsuarioEditar.alias;
                Usuario.email = UsuarioEditar.email;
                Usuario.contrasenia = UsuarioEditar.contrasenia;
                _UsuarioDB.SaveChanges();

                return true;

            }
            catch (Exception error)
            {
                return false;
            }
        }

        public bool Eliminar(int IdUsuario)
        {
            try
            {
                var UsuarioEliminar = _UsuarioDB.Usuario.FirstOrDefault(x => x.IdUsuario == IdUsuario);
                _UsuarioDB.Usuario.Remove(UsuarioEliminar);
                _UsuarioDB.SaveChanges();

                return true;

            }
            catch (Exception error)
            {
                return false;
            }

        }
    }
}
