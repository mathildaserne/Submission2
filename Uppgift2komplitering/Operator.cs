using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Uppgift2komplitering
{
    class Operator : Program
    {
          public static int Evaluate(int a, string op, int b, string op2, int c)
        {
            switch (op)
            {
                default:
                    switch (op2)
                    {
                        case "+":
                            return a + b + c;
                            
                            
                        case "-":
                            return a + b - c;
                            
                            
                        case "*":
                            return a + b * c;
                            

                        default:
                            return a + b + c;
                            break;
                       
                    }
                    break;
                case "-":
                    switch (op2)
                    {
                        case "+":
                            return a - b + c;
                            
                            
                        case "-":
                            return a - b - c;
                            
                            
                        case "*":
                            return a - b * c;
                            

                        default:
                            return a - b + c;
                            break;
                    }
                    break;
                case "*":
                    switch (op2)
                    {
                        case "+":
                            return a * b + c;
                            
                            
                        case "-":
                            return a * b - c;
                            
                            
                        case "*":
                            return a * b * c;
                            

                        default:
                            return a * b + c;
                            break;
                    }
                    break;
                case "/":
                    switch (op2)
                    {
                        case "+":
                            return a / b + c;
                            
                            
                        case "-":
                            return a / b - c;
                            
                            
                        case "*":
                            return a / b * c;
                            

                        default:
                            return a / b + c;
                            break;
                    }
                    break;
                   
            }
        }
    }

}
