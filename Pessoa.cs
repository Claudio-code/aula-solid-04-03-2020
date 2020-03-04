using System;

namespace aula_solid_04_03_2020
{
    public class Pessoa
    {
        private string nome;
        private string documento;
        private string email;

        public Pessoa(string nome, string documento, string email) {
            try
            {
                this.nome = nome;
                this.documento = documento;
                this.email = email;
                Console.WriteLine(this.enviarEmail());
            } 
            catch (System.Exception)
            {
                Console.WriteLine("erro falta parametros ao instanciar a classe"); 
            }
        }

        private string enviarEmail()
        {

            return "Enviando email!!!";
        }
    }
}