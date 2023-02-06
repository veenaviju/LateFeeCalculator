using LateFeeCalculatorService;

namespace LateFeeCalculatorTest
{
    public class LateFeeCalculatorTest
    {
        [Fact]
        public void Test1()
        {
            decimal lateFee = new LateFeeCalculator().Calculate(100, DateTime.Now);
            Assert.Equal(0, lateFee);
        }
    }
}