using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
 
                Console.WriteLine("Executando Proj 8");

                int idadeKleber = 16;

                bool acompanhado = true;

                if (idadeKleber >= 18 && acompanhado == true)
                {
                    Console.WriteLine("Pode entrar");
                }
                else
                {
                    Console.WriteLine("Não pode entrar!");
                }

                Console.ReadLine();
        }
    }
}
