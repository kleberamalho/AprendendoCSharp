using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 6");

            int idade = 28;

            int idadePirollo = idade;

            idade = 10;

            Console.WriteLine(idade);

            Console.WriteLine(idadePirollo);

            Console.ReadLine();
        }
    }
}
