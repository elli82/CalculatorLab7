using CalculatorLab7.Data;
using CalculatorLab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab7
{
    public class DatabaseMethod : Result
    {
        

        public void SaveCalculations(double num1, double num2, string method, double result)     //metod för att spara uträkningar i databasen
        {
            Context dbContext = new Context();  // skapar ett objekt av databasen
            Result calculation = new Result()   // skapar ett objekt av resultaten
            {
                Nr1 = num1,
                Nr2 = num2,
                Method = method,
                Results = result
            };
            dbContext.Results.Add(calculation);     //lägger till i db
            dbContext.SaveChanges();        //sparar i db
        }
        public List<Result> ListOfCalculations()
        {
            Context dbContext = new Context();
            var calculation = dbContext.Results.ToList();
            return calculation;
        }
        public void PrintAllCalculations()
        {
            var calculation = new Calculation();
            List<Result> result = calculation.ListOfCalculations();

            foreach (var item in result)
            {
                Console.WriteLine("Calculation {0}: {1}{2}{3} = {4}", item.Id, item.Nr1, item.Method, item.Nr2, item.Results);
            }
        }
    }
}
