using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab7
{
    public class UserMethod : Calculation
    {
        public (double, double) UsersInput()
        {
            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return (num1, num2);
        }
        public static void PrintResulttoUser(double num1, double num2, string method, double result)
        {
            Console.WriteLine("{0} {1} {2} = {3}", num1, method, num2, result);
        }
    }
}
