using System;
using aula_solid_04_03_2020.Entidades;
using aula_solid_04_03_2020.Servicos;
namespace aula_solid_04_03_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailService.EnviarEmail(new Pessoa("kraudio", "cpf", "teste@gmail.com"));
        }
    }
}
