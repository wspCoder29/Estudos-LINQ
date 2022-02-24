using System;
using System.Linq;




namespace Teste80
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dentro de uma lista o seguinte programa organiza os elementos e
            //Indica quantas vezes os mesmos se repetem

            int[] x = { 2, 5, 4, 3, 6, 2, 5,99, 8, 4, 2, 5, 3 };

            int[] y = x.Distinct().OrderBy(x => x).ToArray();

            Array.Sort(x);

            Console.WriteLine(String.Join(" ", x));
            Console.WriteLine(String.Join(" ", y));

            int count = 0;
            Console.WriteLine();
            for (int i = 0; i< y.Length;i++)
            {
                count = x.Where(x => x == y[i]).Count();
                Console.WriteLine(y[i] + " aparece " + count+"x ");
            }

            
        }
    }
}
