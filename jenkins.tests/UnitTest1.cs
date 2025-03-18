namespace jenkins.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculator calculator = new Calculator();
            Assert.Equal(4, calculator.Add(2, 2));
        }

        [Fact]
        public void Test2()
        {
            Calculator calculator1 = new Calculator();
            Assert.Equal(0, calculator1.Subtract(2, 2));
        }

        [Fact]
        public void Test3()
        {
            Calculator calculator2 = new Calculator();
            Assert.Equal(4, calculator2.Multiply(2, 2));
        }

        [Fact]
        public void Test4()
        {
            Calculator calculator3 = new Calculator();
            Assert.Equal(1, calculator3.Divide(0, 2));
        }
    }
}
