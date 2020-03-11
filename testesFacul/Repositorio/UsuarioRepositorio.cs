using testesFacul.Entidades;
using testesFacul.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testesFacul.Repositorio
{
    public class UsuarioRepositorio : IRepositorioGenerico<Usuario>
    {
        private List<Usuario> _usuarios = new List<Usuario>();

        public UsuarioRepositorio()
        {
            _usuarios.Add(new Usuario("admin", "admin"));
        }

        public void Add(Usuario entity) => _usuarios.Add(entity);
        public ICollection<Usuario> GetAll() => _usuarios;
        public void Remove(Usuario entity) => _usuarios.Remove(entity);

        public void Update(Usuario entity)
        {
            Remove(entity);
            Add(entity);
        }
    }
}