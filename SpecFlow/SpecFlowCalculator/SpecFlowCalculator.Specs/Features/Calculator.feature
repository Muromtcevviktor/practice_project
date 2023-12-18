Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Add
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@Substract
Scenario: Substract two numbers
	Given the first number is 50
	And the second number is 70
	When the second number is substracted from the first number
	Then the result should be -20

@Divide
Scenario: Divide two numbers
	Given the first number is 50
	And the second number is 70
	When the first number is divided by the second number
	Then the result should be 0.7142857313156128

@Multiply
Scenario: Multiply two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are multiplied
	Then the result should be 3500