Feature: Blog Admin 

Background: User has Logged in to the blog admin using valid credentials
	Given user has visited the Blog admin 
	When user enters valid log in details
	| userName                | Password |
	| digital@knightfrank.com | Pa55word |
	Then user should be on the Blog Dashboard page

Scenario: User enters a new tag
	When user clicks on the tag link from the side nav
		And clicks to add a tag
	When user enters a valid tag name
	| tagName        |
	| Automated Test |
	Then user should be on tag management list page with the created tag

Scenario: User creates a new post
	When I select Posts from the Contents drop down press Add post
	Then I should be on the Post Management Create page
	When I enter a page title subtitle and content
		And click create post button
	Then I should see the post on the Post Management List
	When I click edit and Publishing detail button
	When I enter a main image and a thumbnail image
		And select a domain
		And Select a category for the post
		And enter a Tag name
		And and an author name 
		#And user sets a Status for the post
	When click on publish options button
	Then I should be on the post management list with completed post
