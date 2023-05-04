using StringCalculatorKata;

namespace TestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("1,2,3", 6)]    
        public void SupportDifferentDelimiters_Test(string nums, int expected)
        {
            //Act
            var numbers = new StringCalculatorService();
            int actual = numbers.Add(nums);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}