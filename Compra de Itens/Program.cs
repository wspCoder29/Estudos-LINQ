using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Teste77
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //12 1 5.30
            //16 2 5.10
            
            //Compra de itens
            //Indique Codigo Quantidade Valor(com,)
            //Indique Codigo Quantidade Valor(com,)

            string str1 = "12 1 5,30";
            string str2 = "16 2 5,10";

            double[] vd1 = Array.ConvertAll(str1.Split(), double.Parse);

            double[] vd2 = Array.ConvertAll(str2.Split(), double.Parse);

            double calc = (vd1[1] * vd1[2]) + (vd2[1]*vd2[2]);

            Console.WriteLine(calc);










        }
    }
}
