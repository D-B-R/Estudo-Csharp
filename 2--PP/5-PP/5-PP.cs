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

            Console.WriteLine(" Ola Mundo Projeto 5   ");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char) 65; // convertendo para char 

            Console.WriteLine(primeiraLetra);

            primeiraLetra =  (char) (primeiraLetra + 1);

            Console.ReadLine();
        }
    }
}
