using NoticieroApi.Models;
using NoticieroApi.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticieroApi.Services
{
    public class CategoriaService
    {
        public readonly NoticieroDbContext _CategoriaDB;
        public CategoriaService(NoticieroDbContext CategoriaDB)
        {
            _CategoriaDB = CategoriaDB;
        }

        public List<Categoria> VerCategoria()
        {
            var CategoriaBuscada = _CategoriaDB.Categoria.OrderByDescending(x => x.IdCategoria).ToList();
            return CategoriaBuscada;
        }

        public bool Agregar(Categoria CategoriaAgregar)
        {
            try
            {
                _CategoriaDB.Categoria.Add(CategoriaAgregar);
                _CategoriaDB.SaveChanges();
                return true;

            }
            catch (Exception error)
            {
                return false;

            }

        }

        public bool Editar(Categoria CategoriaEditar)
        {
            try
            {
                var Categoria = _CategoriaDB.Categoria.FirstOrDefault(x => x.IdCategoria == CategoriaEditar.IdCategoria);
                Categoria.nombre = CategoriaEditar.nombre;
                Categoria.descripcion = CategoriaEditar.descripcion;
                _CategoriaDB.SaveChanges();

                return true;

            }
            catch (Exception error)
            {
                return false;
            }
        }

        public bool Eliminar(int IdCategoria)
        {
            try
            {
                var CategoriaEliminar = _CategoriaDB.Categoria.FirstOrDefault(x => x.IdCategoria == IdCategoria);
                _CategoriaDB.Categoria.Remove(CategoriaEliminar);
                _CategoriaDB.SaveChanges();

                return true;

            }
            catch (Exception error)
            {
                return false;
            }

        }
    }
}
