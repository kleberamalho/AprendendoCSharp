using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanso proj 11");

            double valorInvestido = 100;


            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;

                Console.WriteLine("Após " + contadorMes + " Meses você tera R$ " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
