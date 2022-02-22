using System;


namespace ExercLinqTest
{

    class Pessoa
    {

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Genero { get; set; }

        public double Salario { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade, string genero, double salario)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
            Salario = salario;
        }

        public override string ToString()
        {
            string str = "\n";
            str += "Nome: " + this.Nome + Environment.NewLine;
            str += "Idade: " + this.Idade + Environment.NewLine;
            str += "Genero: " + this.Genero + Environment.NewLine;
            str += "Salario R$: " + this.Salario + Environment.NewLine;
            return str;
        }


        





    }
}
