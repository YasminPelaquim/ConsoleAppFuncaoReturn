using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFuncaoReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação: a-adição s-subtração m-multiplicação d-divisão");
            string op = Console.ReadLine();

            Console.WriteLine("O resultado é " + operacao(n1, n2, op));

            Console.ReadKey();
        }

        static double operacao(double v1, double v2, string op)
        {
            switch (op)
            {
                case "a":
                    return v1 + v2;                    
                case "s": 
                    return v1 - v2;

                case "m":
                    return v1 * v2;

                case "d":
                    return v1 / v2;

                default: 
                    return 0;

                    
            }
            
        }
    }
}
