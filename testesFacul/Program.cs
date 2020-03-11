using testesFacul.Entidades;
using testesFacul.Interfaces;
using testesFacul.Repositorio;
using testesFacul.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace testesFacul
{
    class Program
    {
        private static readonly UsuarioRepositorio _usuarioRepositorio = new UsuarioRepositorio();
        private static IList<ItemMenu> _itensMenu;

        static void Main(string[] args)
        {
            _itensMenu = GetMenuItems();

            while (true)
            {
                ImprimirMenuItems(_itensMenu);
                var opcao = Console.ReadLine();

                int.TryParse(opcao, out int valorOpcao);

                if (valorOpcao == 0)
                    break;

                if (valorOpcao > _itensMenu.Count)
                    break;

                Executar(valorOpcao);
            }
        }

        private static IList<ItemMenu> GetMenuItems()
            => new List<ItemMenu>
            {
                new ItemMenu("Login"),
                new ItemMenu("Novo Cadastro"),
                new ItemMenu("Recuperar Senha")
            };

        private static void Executar(int valorOpcao)
        {
            ISubitemMenu subitemSelecionado;
            ItemMenu itemMenu = _itensMenu[valorOpcao - 1];
            subitemSelecionado = GetInstance(itemMenu);

            Console.WriteLine();
            string titulo = $"EXECUTANDO: {itemMenu.Titulo}";
            Console.WriteLine(titulo);
            Console.WriteLine(new string('=', titulo.Length));

            subitemSelecionado.Executar();
            Console.WriteLine();
            Console.WriteLine("Tecle algo para continuar...");
            Console.ReadKey();
        }

        private static ISubitemMenu GetInstance(ItemMenu item)
        {
            if (item.Titulo.Equals("Login"))
                return new LoginService(_usuarioRepositorio);

            else if (item.Titulo.Equals("Novo Cadastro"))
                return new CadastroService(_usuarioRepositorio);

            else if (item.Titulo.Equals("Recuperar Senha"))   
                return new RecuperarSenha(_usuarioRepositorio);

            return null;
        }

        private static void ImprimirMenuItems(IList<ItemMenu> itensMenu)
        {
            int i = 1;
            Console.WriteLine("SELECIONE UMA OPÇÃO");
            Console.WriteLine("===================");
            Console.WriteLine("0 - Sair");
            foreach (var item in itensMenu)
                Console.WriteLine((i++).ToString() + " - " + item.Titulo);
        }
    }
}
