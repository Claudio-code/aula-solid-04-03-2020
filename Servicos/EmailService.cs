using System;
using aula_solid_04_03_2020.Entidades;

namespace aula_solid_04_03_2020.Servicos
{
    internal class EmailService
    {
        public static void EnviarEmail(Pessoa pessoa)
            => Console.WriteLine($"Para: pessoa {pessoa}");      
    }
}