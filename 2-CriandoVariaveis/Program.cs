using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando variaveis");

            int idade;
            idade = 28;
            Console.WriteLine("Minha idade é " + idade);

            idade = 10+5;

            Console.WriteLine("Minha idade é " + idade);

            idade = 10 + 5 * 2;

            Console.WriteLine("Minha idade é " + idade);

            Console.WriteLine("Execução finalizada. tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}
