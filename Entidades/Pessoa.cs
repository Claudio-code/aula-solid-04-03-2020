using System;

namespace aula_solid_04_03_2020.Entidades
{
    internal class Pessoa
    {
        private string nome {get; set;}
        private string documento {get; set;}
        private string email {get; set;}

        public Pessoa(string nome, string documento, string email) {
            try
            {
                this.nome = nome ?? throw new Exception("Informar nome");
                this.documento = documento ?? throw new Exception("Informar documentos");
                this.email = email ?? throw new Exception("Informar email");
            } 
            catch (System.Exception)
            {
                Console.WriteLine("erro falta parametros ao instanciar a classe"); 
            }
        }

    }
}