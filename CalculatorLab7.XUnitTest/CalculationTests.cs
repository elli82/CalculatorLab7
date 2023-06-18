namespace CalculatorLab7.XUnitTest
{
    public class CalculationTests
    {
        [Fact]
        public void Addition_Should_Return_Correct_Sum()
        {
            //Arrange
            Calculation testCalculation = new Calculation();
            var nr1 = 10;
            var nr2 = 20;

            //Act
            var actual = testCalculation.Addition(nr1, nr2);
            var exp = 30;

            //Assert
            Assert.Equal(exp, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(20.5, 2, 18.5)]
        [InlineData(10, 20, -10)]
        [InlineData( null, null, null)]
        [InlineData(-5, -3, -2)]
        public void Subtraction_Should_return_Correct_Difference(double nr1, double nr2, double result)
        {
            //Arrange
            var testCalculation = new Calculation();
            //Act
            var actual = testCalculation.Subtraction(nr1, nr2);
            //Assert
            Assert.Equal(result, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(5, 2.5, 12.5)]
        [InlineData(-5, 10, -50)]
        [InlineData(-5, -10, 50)]
        [InlineData(null, null, null)]
        public void Multiplication_Should_Return_Correct_Product(double nr1, double nr2, double result)
        {
            //Arrange
            var testCalculation = new Calculation();
            //Act
            var actual = testCalculation.Multiplication(nr1, nr2);
            //Assert
            Assert.Equal(result, actual);
        }
        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(-5, 5, -1)]
        public void Division_Should_Return_Correct_Quotient(double nr1, double nr2, double result)
        {
            //Arrange
            var testCalculation = new Calculation();
            //Act
            var actual = testCalculation.Division(nr1, nr2);
            //Assert
            Assert.Equal(result, actual);
        }
    }
}