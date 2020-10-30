using System;

namespace ConsoleAppUppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Console.WriteLine("Enter first number. ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first operator. ");
            string Op = Console.ReadLine();

            Console.WriteLine("Enter second number. ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second operator. ");
            string Op1 = Console.ReadLine();

            Console.WriteLine("Enter third number. ");
            int Num3 = Convert.ToInt32(Console.ReadLine());

            switch (Op)
            {
                case "+":
                    switch (Op1)
                    {
                        case "+":
                            result = Num1 + Num2 + Num3;
                            break;
                        case "-":
                            result = Num1 + Num2 - Num3;
                            break;
                        case "*":
                            result = Num1 + Num2 * Num3;
                            break;
                        case "/":
                            result = Num1 + Num2 / Num3;
                            break;
                        default:
                            break;
                    }
                    break;
                case "-":
                    switch (Op1)
                    {
                        case "+":
                            result = Num1 - Num2 + Num3;
                            break;
                        case "-":
                            result = Num1 - Num2 - Num3;
                            break;
                        case "*":
                            result = Num1 - Num2 * Num3;
                            break;
                        case "/":
                            result = Num1 - Num2 / Num3;
                            break;
                        default:
                            break;
                    }
                    break;
                case "*":
                    switch (Op1)
                    {
                        case "+":
                            result = Num1 * Num2 + Num3;
                            break;
                        case "-":
                            result = Num1 * Num2 - Num3;
                            break;
                        case "*":
                            result = Num1 * Num2 * Num3;
                            break;
                        case "/":
                            result = Num1 * Num2 / Num3;
                            break;
                        default:
                            break;
                    }
                    break;
                case "/":
                    switch (Op1)
                    {
                        case "+":
                            result = Num1 / Num2 + Num3;
                            break;
                        case "-":
                            result = Num1 / Num2 - Num3;
                            break;
                        case "*":
                            result = Num1 / Num2 * Num3;
                            break;
                        case "/":
                            result = Num1 / Num2 / Num3;
                            break;
                        default:
                            break;
                    }
                    break;
            }

            Console.WriteLine(" " + Num1 + " " + Op + " " + Num2 + " " + Op1 + " " + Num3 + " = " + result);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Press any key and enter to exit");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
