using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Uppgift2komplitering
{
    class Operator : Program
    {
        /* public/private static? return?  MetodNamnet(data in) 
           {
              Metod kroppen!
           }
        */

          private int Evaluate(int a, string op, int b, string op2, int c) 
        {
            switch (op)
            {
                case "+":
                    switch (op2)
                    {
                        case "+":
                            return a + b + c;
                            
                        case "-":
                            return a + b - c;
                            
                        case "*":
                            return a + b * c;
                            
                        case "/":
                            return a + b / c;
                            
                        default:
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
                            
                        case "/":
                            return a - b / c;
                            
                        default:
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
                            
                        case "/":
                            return a * b / c;
                            
                        default:
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
                            
                        case "/":
                            return a / b / c;
                            
                        default:
                            break;
                    }
                    break;
            }
        }
    }

}
