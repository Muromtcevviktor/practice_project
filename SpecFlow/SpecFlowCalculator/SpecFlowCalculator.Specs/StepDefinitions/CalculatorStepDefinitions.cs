namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private double _result;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = Calculator.Add((int)Calculator.FirstNumber, (int)Calculator.SecondNumber);
        }

        [When("the second number is substracted from the first number")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            _result = Calculator.Substract((int)Calculator.FirstNumber, (int)Calculator.SecondNumber);
        }

        [When("the first number is divided by the second number")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = Calculator.Divide((int)Calculator.FirstNumber, (int)Calculator.SecondNumber);
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = Calculator.Multiply((int)Calculator.FirstNumber, (int)Calculator.SecondNumber);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(double result)
        {
            _result.Should().Be(result);
        }
    }
}