Feature: User_Login_ScopeBinding_Demo
	Simple feature to demonstrate User login feature

@userLogin
Scenario: Login for user portal
	Given I have opened the application
	And I login to application
	Then I see user portal
