using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanso proj 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int ContadorAno = 1; ContadorAno <= 5; ContadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12 ; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao Termino do investimento, você terá R$ " + valorInvestido);

            Console.ReadLine();
        }
    }
}
