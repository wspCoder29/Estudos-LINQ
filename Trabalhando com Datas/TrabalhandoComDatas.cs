using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test81
{
     class Program
    {

        public static void Main(string [] args)
        {

            List<string> li = new List<string>();
            li.Add("Lucia 28 03 1989");
            li.Add("Maria 21 04 1950");
            li.Add("Angela 14 01 2000");
            li.Add("Clara 25 12 2021");
            li.Add("Bia 20 02 2022");

            string nome = "";
            string data = "";

            DateTime nasc;

            TimeSpan ts;

            double idade;

            for (int i = 0; i < li.Count; i++)
            {
                nome = li[i].Substring(0, li[i].IndexOf(" "));
                data = li[i].Substring(li[i].IndexOf(" ") + 1);
                nasc = DateTime.Parse(data);
                ts = DateTime.Now.Subtract(nasc);
                idade = ts.TotalDays / 365;

                if (idade < 1)
                {
                    idade *= 365;
                    Console.WriteLine("Nome: {0} idade: {1:F0} dias", nome, idade);
                }
                else
                {
                    Console.WriteLine("Nome: {0} idade: {1:F0} anos", nome, idade);
                }
            }



        }
    }
}
