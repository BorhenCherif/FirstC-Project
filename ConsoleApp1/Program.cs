using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Input input = new Input();
                Calculator calculator = new Calculator();
                double firstNumber = input.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = input.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();
                double result = calculator.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
