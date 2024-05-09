using net_calculator_tester;

namespace net_calculator_tester_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(1, -2, -1)]
        public void TestAddition(float x, float y, float expectedResult)
        {
            Calculator calculator = new Calculator();
            float result = calculator.Add(x, y);
            Assert.IsTrue(result == expectedResult, $"Expected: {expectedResult}, Actual: {result}");
        }

        [Test]
        [TestCase(5, 3, 2)]
        [TestCase(10, 3, 7)]
        [TestCase(1, -2, 3)]
        public void TestSubtraction(float x, float y, float expectedResult)
        {
            Calculator calculator = new Calculator();
            float result = calculator.Subtract(x, y);
            Assert.IsTrue(result == expectedResult, $"Expected: {expectedResult}, Actual: {result}");
        }

        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(6, 3, 2)]
        public void TestDivision(float x, float y, float expectedResult)
        {
            Calculator calculator = new Calculator();
            float result = calculator.Divide(x, y);
            Assert.IsTrue(result == expectedResult, $"Expected: {expectedResult}, Actual: {result}");
        }

        [Test]
        [TestCase(5, 4, 20)]
        [TestCase(2, 3, 6)]
        public void TestMultiplication(float x, float y, float expectedResult)
        {
            Calculator calculator = new Calculator();
            float result = calculator.Multiply(x, y);
            Assert.IsTrue(result == expectedResult, $"Expected: {expectedResult}, Actual: {result}");
        }
    }
}