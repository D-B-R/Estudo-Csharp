using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_PP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Olá, Projeto 5 em C#");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) 65; // convertendo para char de int 

            Console.WriteLine(primeiraLetra);

            primeiraLetra =  (char) (primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);


            Console.ReadLine();
        }
    }
}
