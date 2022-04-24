using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando 4-Projeto");

            double salario = 1200.50;

            // int variavel de 63 bits
            int salarioInteiro = (int)salario;

            Console.WriteLine("Salario " + salarioInteiro);
            
            //Long variavel de 64 bits
            long idade = 1300000000000000000;
            Console.WriteLine(idade);

            //short variavel de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);


            float altura = 1.80f;
            Console.WriteLine(altura);


            Console.ReadLine();
        }
    }
}
