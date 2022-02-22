using System;
using System.Collections.Generic;
using System.Linq;

namespace Test70
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int [] x = { 2,2,2,2,2,2,2,3,2,2 };

            List<int> li = new List<int>();

            li = x.ToList();

            int qtd = 0;

            qtd = li.Where(x=> x <=2).Count();
            

            Console.WriteLine(qtd);

            Console.WriteLine(string.Join(" ", li));





        }
    }
}
