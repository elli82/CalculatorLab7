using CalculatorLab7.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab7
{
    public class Calculation : DatabaseMethod
    {
        private readonly Context dbContext;

        public Calculation()
        {
            dbContext = new Context();
        }

        public Calculation(Context dbContext)
        {
            this.dbContext = dbContext;
        }

        public double Addition(double num1, double num2)
        {
            string method = "+";
            double result = num1 + num2;
            SaveCalculations(num1, num2, method, result);
            UserMethod.PrintResulttoUser(num1, num2, method, result);
            return result;
        }
        public double Subtraction(double num1, double num2)
        {
            string method = "-";
            double result = num1 - num2;
            SaveCalculations (num1, num2, method, result);
            UserMethod.PrintResulttoUser(num1, num2, method, result);
            return result;
        }
        public double Multiplication(double num1, double num2)
        {
            string method = "*";
            double result = num1 * num2;            
            SaveCalculations(num1, num2, method, result);
            UserMethod.PrintResulttoUser(num1, num2, method, result);
            return result;
        }
        public double Division(double num1, double num2)
        {
            string method = "/";
            double result = num1 / num2;
            SaveCalculations(num1, num2, method, result);   
            UserMethod.PrintResulttoUser(num1, num2, method, result);
            return result;
        }
    }
}
