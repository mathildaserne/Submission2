using System;
using System.Collections.Generic;

namespace Uppgift2komplitering
{

    class Program
    {

        public static string operator_creater()
        {
            string op;
            
            while (true)
            {
                op = Console.ReadLine();
                if (op == "+" || op == "-"  || op == "*" || op == "/")
               break;
     else
                    Console.WriteLine("Please only chose +  - *   /");
                // skapat denna metod för att endast ta emot operatorer.
            }
            return op;
        }

        public static int number_reader()
        {
            int number;
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please only enter integers");
                    // skapat denna metod för att endast ta emot nummer.
                }
            }
            return number;
        }


        static void Main(string[] args)
        {

            List<int> Nums = new List<int>(); // skapat en lista för att ta emot nummer.
            Console.WriteLine("\t\t\t\tEnter first number. ");
            Nums.Add(Program.number_reader());
            Console.WriteLine("\t\t\t\tEnter first operator. ");
            string Op = Program.operator_creater();
            Console.WriteLine("\t\t\t\tEnter second number. ");
            Nums.Add(Program.number_reader());

            Console.WriteLine("\t\t\t\tEnter second operator. ");
            string Op2 = Program.operator_creater();

            Console.WriteLine("\t\t\t\tEnter third number. ");
            Nums.Add(Program.number_reader());

            int result = Operator.Evaluate (Nums[0], Op, Nums[1], Op2, Nums[2]);

            Console.WriteLine(" " + Nums[0] + " " + Op + " " + Nums[1] + " " + Op2 + " " + Nums[2] + " = " + result);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Press any key and enter to exit");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
