Feature: Blog Search
	A series of tests to ensure the blog search function is working correctly


Background: User has visited the blog homepage
	Given user has visited the blog homepage


Scenario: User should see the Blog search icon in the top Navigation
	Then user should see the blog search icon in the top navigation


Scenario: User clicks on the Blog search Icon the Blog search should open
	When user clicks the Blog search icon
	Then the blog search should open and the user should see the words Search the blog
	| blogWatermark   |
	| Search the blog |


Scenario Outline: User searches for blog posts with a valid search term
	When user clicks the Blog search icon
		And performs a free text search for posts with a valid search term <blogSearchInput>
	Then user should see a grid of returned articles featuring the valid search term

Examples: 
	| blogSearchInput |
	| New York        |
	| Horse           |



