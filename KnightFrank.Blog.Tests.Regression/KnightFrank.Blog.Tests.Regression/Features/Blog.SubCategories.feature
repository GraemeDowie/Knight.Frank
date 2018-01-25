Feature: Blog Sub-Categories


Background: User has visited the blog homepage
	Given user has visited the blog homepage


Scenario Outline: User clicks on Property tab then user should see a list of Property Sub Categories
	When user clicks on the property category
		And clicks on the property sub nav bar
	Then user should see a list of property sub categories <propSubCat>

Examples: 
	| propSubCat   |
	| Private View |
	| Rural        |
	| Residential  |
	| Commercial   |



Scenario Outline: User clicks on News tab then user should see a list of News Sub Categories
	When user clicks on the news category
		And clicks on the news sub nav bar
	Then user should see a list of news sub categories <newsSubCat>

Examples: 
	| newsSubCat  |
	| Residential |
	| Commercial  |



Scenario Outline: User clicks on lifestyle tab then user should see a list of lifestyle Sub Categories
	When user clicks on the lifestyle category
		And clicks on the lifestyle sub nav bar
	Then user should see a list of lifestyle sub categories <lifestyleSubCat>

Examples: 
	| lifestyleSubCat    |
	| Working Life       |
	| Private View       |
	| International View |
	| Home Life          |



Scenario Outline: User clicks on Intelligence tab then user should see a list of Intelligence Sub Categories
	When user clicks on the intelligence category
		And clicks on the intelligence sub nav bar
	Then user should see a list of intelligence sub categories <intelligenceSubCat>

Examples: 
	| intelligenceSubCat          |
	| Rural                       |
	| Global Cities               |
	| Residential                 |
	| Global Development Insights |
	| Commercial                  |
	| Luxury                      |
	| The Wealth Report           |