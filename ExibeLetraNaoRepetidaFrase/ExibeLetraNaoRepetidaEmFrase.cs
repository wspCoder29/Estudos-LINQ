using System;
using System.Linq;

namespace Test81
{
    class Program
    {
        public static void Main(string[] args)
        {

            string[] str = { "aaabccccdeeef", "strings", "microsoft visual studio 2022", "abcedoftz", "microsoft visual studio 2022" };

            string test = "";

            for (int a = 0; a < str.Length; a++)
            {
                test = str[a];

                char[] c = test.Trim().Replace(" ", "").ToCharArray();

                var c2 = test.Distinct().ToArray();


                int cont = 0;

                for (int i = 0; i < c2.Length; i++)
                {
                    cont = 0;
                    for (int j = 0; j < test.Length; j++)
                    {
                        if (c2[i] == test[j])
                        {
                            cont++;
                        }
                    }

                    if (cont == 1)
                    {
                        Console.WriteLine("{0} : {1}", c2[i], cont);
                    }
                }

                Console.WriteLine();
            }
        }



    }
}
