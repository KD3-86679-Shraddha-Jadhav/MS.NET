using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {

            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);
            //Console.WriteLine(args[2]);
           // Console.WriteLine("num1 oper num2");
            int num1=int.Parse(args[0]);
            int num2=int.Parse(args[1]);
            string operation=args[2];

            int result = 0;
            //Console.ReadLine();
            switch (operation)
            {
                case"+":
                    result = num1 + num2;
                    Console.WriteLine($"result-{num1}+{num2}={result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"result-{num1}-{num2}={result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"result-{num1}*{num2}={result}");
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"result-{num1}/{num2}={result}");
                    break;


            }
        }
    }
}
