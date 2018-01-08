Feature: CMS Filters are correct

Background: User has visited Knight Frank Homepage
	Given user has visited knight frank homepage

Scenario Outline: Distance filter contains all options
	When user opens the distance filter 
	Then user should see all distance <distanceOptions> filter options
	
Examples: 
	| distanceOptions |
	| This Area Only  |
	| 5 miles         |
	| 10 miles        |
	| 11 miles        |
	| 12 miles        |
	| 13 miles        |
	| 14 miles        |
	| 15 miles        |

	
