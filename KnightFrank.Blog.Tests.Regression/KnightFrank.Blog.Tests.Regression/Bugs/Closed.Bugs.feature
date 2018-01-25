Feature: Closed Bugs
Closed/resolved bug fixes will have an automated test run to ensure we do not re-introduce issues


#bug number: 62453
Scenario: User has visited a new office page and the email button is alled Contact Office
	Given user has visited the commercial leeds office page
	Then user should see an email button labelled Contact Office
	| contactEmailButton    |
	| Contact Office |


#bug number 67650
Scenario Outline: Searching for China on Knighfrank.com.cn no longer returns an error
	Given User has visited Knight Frank China Domain
	| kfChina                           |
	| http://beta.knightfrank.com.cn/en |
	When user clicks on the people office tab 
		And searches for China
		| officeSearch |
		| China        |
	Then user should see a list of office locations in China <chinaOffice>

Examples: 
	| chinaOffice            |
	| Knight Frank Beijing   |
	| Knight Frank Guangzhou |
	| Knight Frank Shanghai	 |
	| Knight Frank Hong Kong |


  #bug number 60794
Scenario: Office search via the services or research tab returns results
	Given user is on the Knight Frank research page
	| researchURL                            |
	| http://beta.knightfrank.co.uk/research |
	When user selects the people office tab and searches for an office
	| officeSearchLocation |
	| Soho                 |
	Then user should see a returned office search with the search location 
	| returnedResult    |
	| Knight Frank Soho |

  #bug number 63665
Scenario: Link to contact agent profile Url takes user to correct profile page
	Given user has visited a Knight Frank Team page on .com
	| teamPage                                                           |
	| http://beta.knightfrank.com/commercial/global-capital-markets/team |
		And selects to view a colleague profile
	Then user should be directed to the correct colleague page
	| colleagueURL                                                    | ContactName  |
	| http://beta.knightfrank.com/contact#/people/andrew-sim-00000085 | Andrew Sim   |


  #bug number 77852

Scenario: user is on service line results page and makes a Residential search
	Given User has conducted a services search from the Knight Frank Homepage
	| serviceSearch          |
	| Global Capital Markets |
	When user selects Residential tab and searches for London
	| resSearch |
	| London    |
	Then user should be taken to search results for their search



