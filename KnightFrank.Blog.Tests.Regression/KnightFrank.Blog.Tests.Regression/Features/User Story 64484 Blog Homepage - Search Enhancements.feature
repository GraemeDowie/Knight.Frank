Feature: User Story 64484 Blog Homepage - Search Enhancements

Background: User has visited the Blog homepage
	Given user has visited the blog homepage
		And opened the search feature

Scenario: User Story 64484: Blog Homepage - Search Enhancements - Search with lower and upper case characters
	When user enters a valid search term with upper and lower case characters
	| SearchTerm  |
	| LoNdoN      |
		And press the return key
	Then user should see a list of related results

Scenario: User Story 64484: Blog Homepage - Search Enhancements - Search with text in quotations 
	When user enters a valid search term using characters with quotations
	| SearchTerm |
	| "New York" |
		And press the return key
	Then user should see a list of related results

Scenario: User Story 64484: Blog Homepage - Search Enhancements - Search with text and numbers
	When user enters a valid search term with characters and numbers
		| SearchTerm        |
		| Private View 2017 |
		And press the return key
	Then user should see a list of related results

Scenario: User Story 64484 Blog Search: Change the text displayed in the search box
	Then User should see placeholder
	| Placeholder     |
	| Search the blog |




