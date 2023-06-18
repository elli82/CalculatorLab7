using CalculatorLab7.Models;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab7.XUnitTest
{
    public class UserMethodTests
    {
        [Fact]
        public void UsersInput_Should_Return_Valid_Input()
        {
            // Arrange
            var consoleInput = new StringReader("5\n10\n");
            Console.SetIn(consoleInput);

            // Act
            var input = new UserMethod();
            var (num1, num2) = input.UsersInput();

            // Assert
            Assert.Equal(5.0, num1);
            Assert.Equal(10.0, num2);
        }
    }
}
