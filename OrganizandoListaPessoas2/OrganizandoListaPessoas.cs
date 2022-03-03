using System;
using System.Collections.Generic;
using System.Linq;

namespace Test81
{
    class Program
    {
        public static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa("Maria", 22, "F", 2000);
            Pessoa p2 = new Pessoa("Pedro", 18, "M", 1500);
            Pessoa p3 = new Pessoa("Aya", 18, "F", 900);
            Pessoa p4 = new Pessoa("Lua", 33, "F", 5000);
            Pessoa p5 = new Pessoa("Zafine", 33, "F", 13000);
            Pessoa p6 = new Pessoa("Aline", 17, "F", 1700);
            Pessoa p7 = new Pessoa("Ju", 37, "F", 1000);

            List<Pessoa> li = new List<Pessoa>();

            li.Add(p1);
            li.Add(p2);
            li.Add(p3);
            li.Add(p4);
            li.Add(p5);
            li.Add(p6);
            li.Add(p7);

            // maior e menor idade
            // qtd mulheres
            // Média dos salarios
            // Gen e idade da pessoa com menor salário


            //Console.WriteLine(String.Join(" ", li));
            Console.WriteLine("===========");

            List<Pessoa> ordered = li.OrderByDescending(x => x.Idade).ToList();

            Console.WriteLine(String.Join(" ", ordered));

            int qtdWoman = ordered.Where(x => x.Genero=="F").Count();

            double mediaSal = ordered.Sum(x => x.Salario)/ordered.Count;

            double mediasalMulheres = ordered.Where(x => x.Genero == "F").Sum(x=>x.Salario)/ordered.Count(x=>x.Genero=="F");

            Console.WriteLine("Maior Idade: "+ ordered[0].Idade);
            Console.WriteLine("Menor Idade: "+ ordered[ordered.Count - 1].Idade);
            Console.WriteLine("Quantidade de Mulheres: "+ qtdWoman);
            Console.WriteLine("Média GERAL de salários R$: {0:F2}", mediaSal);
            Console.WriteLine("Média salário MULHERES R$: {0:F2}", mediasalMulheres);

            ordered = li.OrderBy(x => x.Salario).ToList();

            Console.WriteLine("Gênero e idade da pessoa com menor Salário: "+ordered[0].Genero+" "+ordered[0].Idade);






        }
    }
}