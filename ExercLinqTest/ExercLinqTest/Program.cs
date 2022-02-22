using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercLinqTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa("Maria", 22, "F", 2000);
            Pessoa p2 = new Pessoa("Pedro", 18, "M", 1500);
            Pessoa p3 = new Pessoa("Aya", 18, "F", 900);
            Pessoa p4 = new Pessoa("Lua", 33, "F", 5000);
            Pessoa p5 = new Pessoa("Aline", 17, "F", 1700);
            Pessoa p6 = new Pessoa("Ju", 37, "F", 1000);

            // maior e menor idade
            // qtd mulheres
            // Média dos salarios
            // Gen e idade da pessoa com menor salário

            List<Pessoa> li = new List<Pessoa>();
            li.Add(p1);
            li.Add(p2);
            li.Add(p3);
            li.Add(p4);
            li.Add(p5);
            li.Add(p6);

            Console.WriteLine(String.Join(" ", li));
            Console.WriteLine("=====================");

            //Ordenando por Idade (menor para maior)
            li = li.OrderBy(x => x.Idade).ToList();

            //qtd mulheres na região
            int qtdF = li.Where(x => x.Genero.Equals("F")).Count();

            double mediaSal = li.Average(x => x.Salario);

            Console.WriteLine("Menor idade: "+li[0].Nome+" "+li[0].Idade);
            Console.WriteLine("Maior idade: " +li[li.Count-1].Nome + " " + li[li.Count-1].Idade);
            Console.WriteLine("Quantidade de mulheres na região: "+qtdF);
            Console.WriteLine("Média de salários na região R$:{0:F2}",mediaSal);







        }
    }
}
