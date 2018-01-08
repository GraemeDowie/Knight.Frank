Feature: User Story 66239 Blog - UI changes to article pages


Scenario: User Story 66239: Blog - UI changes to article pages - All Categories 
	Given user has visited the blog homepage
	Then the all categories tab should be selected and background color is Red

Scenario: User Story 66239: Blog - UI changes to article pages - Property Category
	Given user has visited the blog homepage
	When User selects the Property Category 
	Then the Property category background should be Blue

Scenario: User Story 66239: Blog - UI changes to article pages - News Category
	Given user has visited the blog homepage
	When User selects the News Category 
	Then the News category background should be Purple

Scenario: User Story 66239: Blog - UI changes to article pages - Lifestyle Category
	Given user has visited the blog homepage
	When User selects the Lifestyle Category 
	Then the Lifestyle category background should be Orange

Scenario: User Story 66239: Blog - UI changes to article pages - Intelligence Category
	Given user has visited the blog homepage
	When User selects the intelligence Category 
	Then the Intelligence category background should be Yellow

Scenario: User Story 66239: Blog - UI changes to article pages - mobile - Intelligence Category
	Given user has visited blog homepage on mobile device
	When user selects the hamburger menu	
		And selects the intelligence category
		And closes the hamburger menu
	Then user should see the intelligence sub category menu
		And Intelligence category posts

Scenario: User Story 66239: Blog - UI changes to article pages - mobile - Lifestyle Category
	Given user has visited blog homepage on mobile device
	When user selects the hamburger menu	
		And selects the lifestyle category
		And closes the hamburger menu
	Then user should see the lifestyle sub category menu
		And lifestyle category posts

Scenario: User Story 66239: Blog - UI changes to article pages - mobile - News Category
	Given user has visited blog homepage on mobile device
	When user selects the hamburger menu	
		And selects the news category
		And closes the hamburger menu
	Then user should see the news sub category menu
		And news category posts

Scenario: User Story 66239: Blog - UI changes to article pages - mobile - Property Category
	Given user has visited blog homepage on mobile device
	When user selects the hamburger menu	
		And selects the property category
		And closes the hamburger menu
	Then user should see the property sub category menu
		And property category posts

Scenario: User Story 66239: Blog - UI changes to article pages - Tablet - Intelligence Category
	Given user has visited blog homepage on tablet device
	When user selects the hamburger menu	
		And selects the intelligence category
		And closes the hamburger menu
	Then user should see the intelligence sub category menu
		And Intelligence category posts

Scenario: User Story 66239: Blog - UI changes to article pages - Tablet - Lifestyle Category
	Given user has visited blog homepage on tablet device
	When user selects the hamburger menu	
		And selects the lifestyle category
		And closes the hamburger menu
	Then user should see the lifestyle sub category menu
		And lifestyle category posts

Scenario: User Story 66239: Blog - UI changes to article pages - Tablet - News Category
	Given user has visited blog homepage on tablet device
	When user selects the hamburger menu	
		And selects the news category
		And closes the hamburger menu
	Then user should see the news sub category menu
		And news category posts

Scenario: User Story 66239: Blog - UI changes to article pages - Tablet - Property Category
	Given user has visited blog homepage on tablet device
	When user selects the hamburger menu	
		And selects the property category
		And closes the hamburger menu
	Then user should see the property sub category menu
		And property category posts

Scenario: User Story 66239: Blog - UI changes to article pages -Large Tablet - All Categories 
	Given user has visited blog homepage on large tablet device
	Then the all categories tab should be selected and background color is Red

Scenario: User Story 66239: Blog - UI changes to article pages - Large Tablet - Intelligence Category
	Given user has visited blog homepage on large tablet device
	When User selects the intelligence Category 
	Then the Intelligence category background should be Yellow

Scenario: User Story 66239: Blog - UI changes to article pages - Large Tablet - Lifestyle Category
	Given user has visited blog homepage on large tablet device
	When User selects the Lifestyle Category 
	Then the Lifestyle category background should be Orange

Scenario: User Story 66239: Blog - UI changes to article pages - Large Tablet - News Category
	Given user has visited blog homepage on large tablet device
	When User selects the News Category 
	Then the News category background should be Purple

Scenario: User Story 66239: Blog - UI changes to article pages - Large Tablet - Property Category
	Given user has visited blog homepage on large tablet device
	When User selects the Property Category 
	Then the Property category background should be Blue