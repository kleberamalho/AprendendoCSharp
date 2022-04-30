using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Proj 9");


            int idadeKleber = 18;
            bool acompanhado = true;
            string mensagemAdicional;


            if (acompanhado == true)
            {
                 mensagemAdicional = "Jão kleber esta acompanhado";
            }
            else
            {
                 mensagemAdicional = "Jão Kleber não esta acompanhado";
            }

            if (idadeKleber >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

            Console.ReadLine();
        }
    }
}
