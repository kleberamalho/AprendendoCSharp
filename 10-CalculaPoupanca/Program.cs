using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanso proj 10");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <=12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Ápós " + contadorMes + " mese, você terá R$" + valorInvestido);

                contadorMes++;
            }
            // 0.36% = 0.0036
            Console.ReadLine();
        }
    }
}
