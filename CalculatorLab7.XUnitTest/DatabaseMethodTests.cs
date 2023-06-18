using CalculatorLab7.Data;
using CalculatorLab7.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab7.XUnitTest
{
    public class DatabaseMethodTests
    {
        [Fact]
        public void SaveCalculations_Should_Add_Data_To_Database()  //does not work
        {
            //Arrange
            double num1 = 5;
            double num2 = 5;
            string method = "+";
            double result = 10;

            var dbContextMock = new Mock<Context>();  //create a fake db

            var calculation = new Calculation(dbContextMock.Object);

            //Act
           calculation.SaveCalculations(num1, num2, method, result);

            //Assert
            dbContextMock.Verify(db => db.Add(It.Is<Result>(c =>
            c.Nr1 == num1 &&
            c.Nr2 == num2 &&
            c.Method == method &&
            c.Results == result)), Times.Once);        

            // Verify that SaveChanges method is called
            dbContextMock.Verify(db => db.SaveChanges(), Times.Once);
        }
        [Fact] 
        public void PrintAllCalculations_Should_Print_All_Results()
        {
            // Arrange
            var calculation = new Calculation();
            List<Result> expectedResult = calculation.ListOfCalculations();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            calculation.PrintAllCalculations();
            string output = consoleOutput.ToString().Trim();

            // Assert
            int expectedCount = expectedResult.Count;
            int actualCount = output.Split('\n').Length;
            Assert.Equal(expectedCount, actualCount);

            for (int i = 0; i < expectedCount; i++)
            {
                Result expected = expectedResult[i];
                string expectedOutput = string.Format(
                    "Calculation {0}: {1}{2}{3} = {4}",
                    expected.Id, expected.Nr1, expected.Method, expected.Nr2, expected.Results
                );
                string actualOutput = output.Split('\n')[i].Trim();
                Assert.Equal(expectedOutput, actualOutput);
            }
        }
    }

}

