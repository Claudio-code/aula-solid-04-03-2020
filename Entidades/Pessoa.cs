using System;

namespace aula_solid_04_03_2020.Entidades
{
    public class Pessoa
    {
        public string nome {get; private set;}
        public string documento {get; private set;}
        public string email {get; private set;}

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