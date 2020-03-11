using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testesFacul.Entidades
{
    public class Usuario
    {
        public string Nome { get; private set; }
        public string Senha { get; private set; }

        public Usuario(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }
    }
}
