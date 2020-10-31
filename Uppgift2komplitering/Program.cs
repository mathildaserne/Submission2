using System;
using System.Collections.Generic;

namespace Uppgift2komplitering
{

    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> Nums = new List<int>();
            // Istället för Num1, Num2, ...
            // Ha en Num array som håller alla värden
            Console.WriteLine("\t\t\tEnter first number. ");
            Nums[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t\t\tEnter first operator. ");
            string Op = Console.ReadLine();
            Console.WriteLine("\t\t\tEnter second number. ");
            Nums[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\t\t\tEnter second operator. ");
            string Op1 = Console.ReadLine();

            Console.WriteLine("\t\t\tEnter third number. ");
            Nums[2] = Convert.ToInt32(Console.ReadLine());


            int result = Operator.Evaluate (Nums[0], Op, Nums[1], Op1, Nums[2]);

            Console.WriteLine(" " + Nums[0] + " " + Op + " " + Nums[1] + " " + Op1 + " " + Nums[2] + " = " + result);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Press any key and enter to exit");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
