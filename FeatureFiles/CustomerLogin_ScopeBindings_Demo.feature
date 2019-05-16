Feature: CustomerLogin_ScopeBindings_Demo
	Simple feature to demonstrate User login feature

@customerLogin
Scenario: Login for customer portal
	Given I have opened the application
	And I login to application
	Then I see customer portal
