Feature: OfficePageNew


Background: user has visited an office using the new office page design
	Given user has visited Leeds office page 
	| officePage                                                     |
	| http://www.knightfrank.co.uk/contact/commercial-property-leeds |

Scenario Outline: User should see global site navigation
	Then user should see <globalNav> global navigation

Examples: 
	| globalNav       |
	| Country: UK     |
	| About           |
	| Careers         |
	| Contact us      |
	| My Knight Frank |

Scenario: user should see the red my knight frank 
	Then my knight frank on the global nav should be red
	| myKnightFrankRed |
	| rgba(208, 16, 58, 1) |



Scenario Outline: User should see site navigation bar
	Then user should see <siteNav> site nav

Examples: 
	| siteNav          |
	| Properties       |
	| People / Offices |
	| Services         |
	| Research         |
	| Blog             |
	
Scenario: user should see the site nav bar is green
	Then user sees site nav bar is green
	| siteNavGreen       |
	| rgba(1, 81, 81, 1) |

Scenario: User should see an image in the search area
	Then user should see the image in the search area
	| leedsImage                                                                      |
	| url("http://www.knightfrank.co.uk/resources/commercial/leeds-header-image.jpg") |
		
Scenario Outline: User should see the search box tabs
	Then user should see the <searchBoxTabs> search box tab options

Examples: 
	| searchBoxTabs    |
	| Residential      |
	| Commercial       |
	| People / Offices |
	| Services         |
	| Research         |
