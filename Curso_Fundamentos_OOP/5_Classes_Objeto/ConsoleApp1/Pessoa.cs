using System;

namespace ConsoleApp1
{
    class Pessoa
    {
        //field
        public string nome;
        public int idade;
        public string genero;

        public Pessoa()
        {
        }

        public Pessoa(string nome, int idade, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public void Identificar() 
        {
            Console.WriteLine($"Olá, sou o {nome} tenho {idade} e sou do sexo {genero}");
        }
    }
}
