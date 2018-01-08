Feature: CMS Navigation

Background: User has visited the Knight Frank UK homepage
	Given user has visited the knight frank homepage

Scenario Outline: Global Navigation is visible
	Then user should see <greenNav> Green Navigation

Examples: 
	| greenNav         |
	| Properties       |
	| People / Offices |
	| Services         |
	| Research         |
	| Blog             |


Scenario Outline: Search box tabs are visible
	Then user should see <searchTabs> Search Tabs

Examples: 
	| searchTabs       |
	| Residential      |
	| Commercial       |
	| People / Offices |
	| Services         |
	| Research         |

Scenario Outline: Global Nav is Visible after searching
	When user searchs for <location> location
	When results are returned the <globalNav> Global Navigation should be visible

Examples: 
	| location  | globalNav       |
	| London    | Country: Global |
	| London    | About           |
	| London    | Careers         |
	| London    | Contact us      |
	| London	| My Knight Frank |


