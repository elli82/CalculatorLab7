using CalculatorLab7.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab7.Models
{
    public class Result
    {        
        [Key]
        public int Id { get; set; }
        public double Nr1 { get; set; }
        public double Nr2 { get; set; }
        public string Method { get; set; }
        public double Results { get; set; }

        public Result()
        {
        }
        public Result(double num1, double num2, string method, double _results)
        {
            Nr1 = num1;
            Nr2 = num2;
            Method = method;
            Results = _results;
        }
    }
}
