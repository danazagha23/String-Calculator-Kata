using StringCalculatorKata;

namespace TestProject
{
    public class UnitTest1
    {

        [Fact]
        public void NegativeNumbers_Test()
        {
            var numbers = new StringCalculatorService();

            var exception = Assert.Throws<Exception>(() => numbers.Add("-2,4,5"));

            //Assert
            Assert.Equal("negatives not allowed: -2", exception.Message);
        }

        [Theory]
        [InlineData("//;\n2;3;1;5", 11)]
        public void SupportDifferentDelimiters_Test(string nums, int expected)
        {
            //Act
            var numbers = new StringCalculatorService();
            int actual = numbers.Add(nums);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("1,2,3", 6)]    
        public void HandleNewLinesBetweenNums_Test(string nums, int expected)
        {
            //Act
            var numbers = new StringCalculatorService();
            int actual = numbers.Add(nums);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}