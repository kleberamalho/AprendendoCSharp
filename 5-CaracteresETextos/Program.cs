using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = "https://www.bing.com/search?q=ascii+table&cvid=d7921cb82f9846f6a23a52fe4acd4863&aqs=edge..69i57j69i64.3472j0j1&pglt=427&FORM=ANNTA1&PC=U531";
            Console.WriteLine(link);

            Console.WriteLine("Executando Projeto 5");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;

            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Curso C# " + 2022;

            string cursoProgramacao = @" 
                                         - .NET
                                         - Java
                                         - JavaScript";

            Console.WriteLine(cursoProgramacao);

            Console.WriteLine(titulo);
            

            Console.ReadLine();
        }
    }
}
