Feature: Blog categories
	A series of tests to confirm the categories are visible and also that they are selectable and return posts

Background: User has visited the Blog homepage
	Given user has visited the blog homepage


Scenario Outline: user should see a list of categories in the top navigation and All Categories should have a red background
	Then user should see a list of categories in the top navigation <blogCategories>

Examples: 
	| blogCategories |
	| All Categories |
	| Property       |
	| News           |
	| Lifestyle      |
	| Intelligence   |

Scenario: user should see the All categories selected with a red background
	Then User should see the All Categories selected with a red background


Scenario: user clicks on the property category then it should have the correct background color and an active class
	When user selects the Property category
	Then the background color should be correct
	| propertyBGColor      |
	| rgba(0, 204, 193, 1) |
		And the class should be active


Scenario: user clicks on the News category then it should have the correct background color and an active class
	When user selects the News category
	Then the News background color should be correct
	| newsBGColor           |
	| rgba(187, 22, 123, 1) |
		And the News class should be active


Scenario: user clicks on the Lifestyle category then it should have the correct background color and an active class
	When user selects the Lifestyle category
	Then the Lifestyle background color should be correct
	| lifestyleBGColor           |
	| rgba(255, 147, 70, 1)		 |
		And the Lifestyle class should be active	

Scenario: user clicks on the Intelligence category then it should have the correct background color and an active class
	When user selects the Intelligence category
	Then the Intelligence background color should be correct
	| intelligenceBGColor           |
	| rgba(18, 121, 199, 1)		 |
		And the Intelligence class should be active