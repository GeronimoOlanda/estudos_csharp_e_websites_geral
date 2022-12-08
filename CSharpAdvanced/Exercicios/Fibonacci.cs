using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Exercicios
{
    public class Fibonacci
    {
        int a = 0, b = 1, c = 0;

      public void FibonacciValue()
        {
            Console.WriteLine("Quantos Valores: ");
            int valores = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sequência de Fibonacci com {valores} valores.");

            for(int i = 0; i < valores; i++)
            {
               if(i < valores - 1)
                {
                    Console.WriteLine(a + ", ");
                }
                else
                {
                    Console.WriteLine(a);
                }
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
