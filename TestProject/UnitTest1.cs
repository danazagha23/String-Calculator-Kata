using StringCalculatorKata;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Add_Test()
        {
            //Arrange 
            int expected = 10;

            //Act
            var numbers = new StringCalculatorService();
            int actual = numbers.Add("2,3,4,1");

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}