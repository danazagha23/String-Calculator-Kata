using StringCalculatorKata;

namespace TestProject
{
    public class UnitTest1
    {
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