using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_ingresso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vi, vid;

            Console.WriteLine("insira o valor do ingresso:");
            vi = double.Parse(Console.ReadLine());
            if (vi > 200)
            {
                vid = vi * 0.90;
                Console.WriteLine("o valor com desconto aplicado é " + vid + " Reais");
            }
            else
            {
                Console.WriteLine("não há desconto.");
            }
        }
    }
}
