using System;
using System.Linq;
using System.Collections.Generic;


namespace ListaCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // string listaCompras = "banana maca banana feijao maca amora";
            Console.WriteLine("Indique a qtd de listas de compras: ");
            int qtd = int.Parse(Console.ReadLine());

            string[] str = new string[qtd];

            string listaCompras = "";
            for (int i = 0; i<qtd;i++)
            {
                Console.WriteLine("Lista {0}:",i+1);
                Console.WriteLine("Indique os elementos da lista {0} ", i+1);
                listaCompras = Console.ReadLine();
                str = listaCompras.Split();

                str = str.OrderBy(x => x).Distinct().ToArray();

                Console.WriteLine("Itens ordenados");
                Console.WriteLine(String.Join(" ",str));

            }

            Console.WriteLine("Fim");
           




           


        }
    }
}
