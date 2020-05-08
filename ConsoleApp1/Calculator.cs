using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Calculator
    {
       public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;

            switch(argOperation.ToLower())
            {

                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "substract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "multiplay":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;
                default:

                 throw new InvalidOperationException("specify operation not regonise");

            }

            return result;

        }
             
            

        }
}
