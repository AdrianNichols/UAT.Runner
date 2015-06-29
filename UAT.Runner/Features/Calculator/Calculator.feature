Feature: Calculator 
	In order to prove this project works,
	As a developer,
	I want to be able to use http://www.calculator.net/	
	

@exampleScenarios
Scenario Outline: Add two numbers
	Given I am on the calculator home page
	And I have entered the formula <p0> + <p1> 
	When I press equals
	Then the result should be <answer> on the screen

	Examples:
	| answer | p0 | p1 |
	| 5      | 1  | 4  |
	| 7      | 2  | 5  |
	| 9      | 3  | 6  |
	| 11     | 5  | 6  |
	| 13     | 4  | 9  |