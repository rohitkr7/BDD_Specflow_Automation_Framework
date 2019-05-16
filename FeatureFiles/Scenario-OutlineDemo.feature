Feature: Scenario-OutlineDemo
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	
@mytag_singleSetOfData
Scenario: Create a new employee with mandatory fields for single set of data
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory details in form
	| Name   | Age	| Phone				| Email					 |
	| Kartik | 25	|     9851638768	|   kartiktkrroy@fb.com  |
	#And I click save button
	#Then Then I should see all the details saved in my application and DB


@mytag_multipleSetOfData
Scenario: Create a new employee with mandatory fields for multiplse Set of Data
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory details in form with multiple Data
	| Name   | Age	| Phone				| Email					 |
	| Kartik | 25	|     9851638768	|   kartiktkrroy@fb.com  |
	| Rohit	 | 25	|     9851000768	|   rohitkrroy@fb.com    |
	| Smart	 | 25	|     9851688868	|   smarty@fb.com		|
	#And I click save button
	#Then Then I should see all the details saved in my application and DB


@mytag_multipleSetOfData_UsingSpecflowAssistDynamics
Scenario: Create a new employee with mandatory fields for multiplse Set of Data using Specflow_Assist_Dynamics
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory details in form with multiple Data using Specflow_Assist_Dynamics
	| Name   | Age	| Phone				| Email					 |
	| Kartik | 25	|     9851638768	|   kartiktkrroy@fb.com  |
	| Rohit	 | 25	|     9851000768	|   rohitkrroy@fb.com    |
	| Smart	 | 25	|     9851688868	|   smarty@fb.com		|
	#And I click save button
	#Then Then I should see all the details saved in my application and DB


# Scenario Outline is used to iterate through different set of data for same scenario/Testcase
Scenario Outline: Create a new employee with mandatory fields for different iterations
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all the mandatory details in form <Name>,<Age> and <Phone>
	
	#And I click save button
	#Then Then I should see all the details saved in my application and DB
Examples: 
	| Name   | Age	| Phone				| 
	| Kartik | 25	|     9851638768	| 
	| Rohit	 | 25	|     9851000768	| 
	| Smart	 | 25	|     9851688868	| 
