using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test81
{
    class Program
    {

        public static void Main(string[] args)
        {

            //Calculando Mediana - OBS SEMPRE ORDENAR OS ITENS ANTES DE CALCULAR MEDIANA

            string str = "13 12 10 15 14 14 15 20 19 18"; // lenght par

            //string str = "12 15 17 18 20 19 21"; // lenght impar

            Console.WriteLine("chuchuchcu");

            str = str.Trim();

            int[] x = Array.ConvertAll(str.Split(" "), int.Parse);

            Array.Sort(x);

            Console.WriteLine(string.Join(" ", x) + " length: "+x.Length);

            int len = 0;
            int pos1 = 0;
            int pos2 = 0;
            double mediaSimples = 0;

            //SE O LENGHT DO ARRAY FOR PAR
            if (x.Length % 2 == 0)
            {
                len = x.Length / 2;
                pos1 = len-1;
                pos2 = len + 1;
                mediaSimples = (x[pos1] + x[pos2]) / 2;
                Console.WriteLine("Mediana {0:F0}", mediaSimples);
            }
            //ARRAY LENGHT IMPAR
            else
            {

                len = x.Length / 2;
                Console.WriteLine("Mediana = {0:F0}",x[len]);
            }
        
        }

    }
}
