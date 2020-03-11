using testesFacul.Interfaces;
using testesFacul.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace testesFacul.Servicos
{
    public class CadastroService : ISubitemMenu
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public CadastroService(UsuarioRepositorio usuarioRepositorio) 
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Executar()
        {
            Console.WriteLine("Informe seu usuário: ");
            var nomeUsuario = Console.ReadLine();

            Console.WriteLine("Informe sua nova senha: ");
            var senhaUsuarioNova = Console.ReadLine();
            
            Console.WriteLine("Informe sua nova senha para confirmar: ");
            var senhaUsuarioNovaConfirmar = Console.ReadLine();
            
            if (!senhaUsuarioNova.Equals(senhaUsuarioNovaConfirmar))
            {
                Console.WriteLine("Senha invalida !!");
            }

            var usuario = _usuarioRepositorio.GetAll().FirstOrDefault(x => x.Nome.Equals(nomeUsuario) && x.Senha.Equals(senhaUsuarioNova));
            
            if (usuario == null)
                Console.WriteLine("Usuário Cadastrado com sucesso");
            else
                Console.WriteLine($"Esse usuario ja existe {usuario.Nome}");
        }
    }
}