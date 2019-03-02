Feature: GoogleSearch
	In order to confirm that
	Every time I search something in google
	corresponding matching results should show up.

@mytag
Scenario: Google Search
	Given I am on the google homepage
	And I entered India in the search box
	When I press search button
	Then seacrh results for India - Wikipedia should be displayed
