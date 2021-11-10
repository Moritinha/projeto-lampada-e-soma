using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            var soma = 0;
            int input = Convert.ToInt32(Console.ReadLine());
 
            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    soma += i;

                }

            }
            Console.WriteLine("soma:" + soma);
            Console.ReadKey();
            
        }
    }
}
