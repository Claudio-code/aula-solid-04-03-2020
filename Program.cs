using System;
using aula_solid_04_03_2020.Entidades;
using aula_solid_04_03_2020.Servicos;
namespace aula_solid_04_03_2020
{
    class Program
    {
        private static readonly ServicosBancarios _servicoBancario = new ServicosBancarios();

        static void Main(string[] args)
        {
            
            var pessoa = new Pessoa("00000000000", "Juliano", "juliano@mail.com");
            EmailService
                .EnviarEmail(pessoa);

            Console.WriteLine("\n");
            var contaPou = new ContaPoupancao(new Pessoa("kraudio", "cpf", "teste@gmail.com"));
            var contaPoupanca = new ContaPoupancao(pessoa);

            _servicoBancario.Depositar(contaPoupanca, 10.00m);
            _servicoBancario.Sacar(contaPoupanca, 10.00m);
            _servicoBancario.GetSaldo(contaPoupanca);

            

        }
    }
}
