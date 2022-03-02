using System;
using System.Linq;
using System.Collections.Generic;

namespace Test81
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //REMOVENDO ELEMENTOS REPETIDOS DE ARRAYS

            string str = "3 1 56 77 9 2 1";

            string[] names = { "hello", "hello", "stack", "stack", "overflow", "overflow" };

           var query = names.Distinct();

            Console.WriteLine(string.Join(" ",query));

            int [] x = Array.ConvertAll(str.Split(" "), int.Parse);

            Array.Sort(x);

            var x2 = x.Distinct();

            Console.WriteLine(string.Join(" ", x2));



        }
    }
}
