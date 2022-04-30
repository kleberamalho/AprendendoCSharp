using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Proj 7");

            int idadeKleber = 16;
            int quantidadePessoas = 2;

            if (idadeKleber >= 18)
            {
                Console.WriteLine("Possui mais de 18 anos de idade");
            }
            else
            {

                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Não Possui mais de 18 anos, mais esta acompanhado. Pode Entrar");
                }
                else { Console.WriteLine("Não possui mais de 18 não pode entrar!"); }
            }

            Console.ReadLine();
        }
    }
}
