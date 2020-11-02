using System;
using System.Collections.Generic;

namespace Uppgift2komplitering
{

    class Program
    {

        public string operator_creater()
        {
            string op = operator_creater();
            string op2 = operator_creater();
            while (true)
            {
                op = Console.ReadLine();
                if (op == "+" || op == "-"  || op == "*" || op == "/")
               break;
     else
                    Console.WriteLine("Please only chose +  - *   /");
            }
            return op;
        }

            

        static void Main(string[] args)
        {

            List<int> Nums = new List<int>();
            Console.WriteLine("\t\t\tEnter first number. ");
            Nums.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\t\t\tEnter first operator. ");
            string Op = Console.ReadLine();
            Console.WriteLine("\t\t\tEnter second number. ");
            Nums.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("\t\t\tEnter second operator. ");
            string Op2 = Console.ReadLine();

            Console.WriteLine("\t\t\tEnter third number. ");
            Nums.Add(Convert.ToInt32(Console.ReadLine()));

            int result = Operator.Evaluate (Nums[0], Op, Nums[1], Op2, Nums[2]);

            Console.WriteLine(" " + Nums[0] + " " + Op + " " + Nums[1] + " " + Op2 + " " + Nums[2] + " = " + result);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Press any key and enter to exit");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
