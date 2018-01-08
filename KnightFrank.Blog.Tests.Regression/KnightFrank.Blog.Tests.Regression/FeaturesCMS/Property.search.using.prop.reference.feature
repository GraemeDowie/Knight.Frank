Feature: Residential Buy Property Search
	This feature includes searching for property on the CMS using Property Reference, Postcode and Country

Background: user has visited the Knight Frank Homepage
		Given user has visited the knight frank homepage

Scenario: Property Search using Property Reference at the end of URL
	When user enters a valid property reference at the end of the url
	| Reference | 
	| sla130404 |
	Then user should be taken directly to the PDP page of the property
		
Scenario: Property Search using Property Reference
	When user enters a valid property reference
	| Reference |
	| sla130404 |
		And clicks the search button
	Then user should be taken directly to the PDP page of the property

Scenario: Property Search using Postcode
	When user enters a valid postcode
	| Postcode |
	| SW4 |
		And clicks the search button
	Then user should be taken to results for that postcode area

Scenario: Property Search using Postcode and House Filter
	When user enters a valid postcode
	| Postcode |
	| SW4 |
		And selects the house filter 
		And clicks the search button
	Then user should be taken to results for that postcode area and houses as a property type

Scenario: Property Search using Country
	When user enters a valid Country
	| Country |
	| Germany |
		And clicks the search button
	Then user should be taken to results for that Country

