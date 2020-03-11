using testesFacul.Interfaces;
using testesFacul.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testesFacul.Servicos
{
    public class RecuperarSenha : ISubitemMenu
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public RecuperarSenha(UsuarioRepositorio usuarioRepositorio) 
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Executar()
        {
            Console.WriteLine("Informe seu usuário: ");
            var nomeUsuario = Console.ReadLine();
            var usuario = _usuarioRepositorio.GetAll().FirstOrDefault(x => x.Nome.Equals(nomeUsuario));
            
            if (usuario != null)
            {
                Console.WriteLine("Informe sua nova senha: ");
                var senhaUsuarioNova = Console.ReadLine();
                
                Console.WriteLine("Informe sua nova senha para confirmar: ");
                var senhaUsuarioNovaConfirmar = Console.ReadLine();
                
                if (!senhaUsuarioNova.Equals(senhaUsuarioNovaConfirmar))
                {
                    Console.WriteLine("Senha invalida !!");
                }
            }
            else
            {
                Console.WriteLine("Usuário ou senha inválidos! Verifique.");
            }
        }
        
    }
}