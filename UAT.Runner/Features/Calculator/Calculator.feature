Feature: Calculator 
	In order to prove this project works,
	As a developer,
	I want to be able to use http://www.calculator.net/	
	
Background:
	Given I want to navigate to http://www.calculator.net/

@exampleScenarios
Scenario Outline: Add two numbers
	Given I have entered the formula <p0> + <p1> 
	When I press equals
	Then the result should be <answer> on the screen

	Examples:
	| answer | p0 | p1 |
	| 5      | 1  | 4  |
	| 7      | 2  | 5  |
	| 9      | 3  | 6  |
	| 11     | 5  | 6  |
	| 13     | 4  | 9  |

@exampleScenarios
Scenario Outline: Subtract one number from another
	Given I have entered the formula <p0> - <p1> 
	When I press equals
	Then the result should be <answer> on the screen

	Examples:
	| answer | p0 | p1 |
	| 4      | 5  | 1  |
	| 2      | 7  | 5  |
	| 6      | 9  | 3  |

	
@exampleScenarios
Scenario Outline: Subtract one number from another badly
	Given I have entered the formula <p0> - <p1> 
	When I press equals
	Then the result should be <answer> on the screen

	Examples:
	| answer | p0 | p1 |
	| 4      | 6  | 1  |