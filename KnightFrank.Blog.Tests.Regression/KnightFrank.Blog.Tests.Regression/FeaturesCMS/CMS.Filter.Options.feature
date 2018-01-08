Feature: CMS Filter Options


Scenario Outline: Distance Filter has correct options
	Given user has visited knight frank homepage
	When user opens the distance filter
	Then user should see <distanceValue> distance values

	Examples: 
	| distanceValue  |
	| Distance       |
	| This Area Only |
	| 5 miles        |
	| 10 miles       |
	| 11 miles       |
	| 12 miles       |
	| 13 miles       |
	| 14 miles       |
	| 15 miles       |


Scenario Outline: Property type filter has correct options
	Given user has visited the knight frank homepage
	When user opens the property types filter
	Then user should see <propertyValue> property values

Examples: 
	| propertyValue     |
	| Property Type     |
	| House             |
	| Flat              |
	| Farms & land      |
	| New homes         |
	| Development       |
	| Other residential |


Scenario Outline: Bedroom Filter has correct options
	Given user has visited the knight frank homepage
	When user opens the bedroom filter
	Then user should see <bedroomValue> bedroom values

Examples: 
	| bedroomValue |
	| Bedrooms     |
	| Studio       |
	| 1+           |
	| 2+           |
	| 3+           |
	| 4+           |
	| 5+           |

Scenario Outline: Commercial Property types have correct options
	Given user has visited the knight frank homepage
	When user opens commercial property type filter
	Then user should see commercial <comPropertyTypes> property types

Examples: 
	| comPropertyTypes |
	| Property Types   |
	| Offices          |
	| Serviced Offices |
	| Development      |
	| Industrial       |
	| Commercial land  |
	| Hotels & leisure |
	| Retail           |
	| Other commercial |


Scenario Outline: Commercial Floor area have correct options
	Given user has visited the knight frank homepage
	When user opens commercial Floor area filter
	Then user should see commercial <comFloorArea> floor area

Examples: 
	| comFloorArea         |
	| Floor area           |
	| 0 - 100 sqft         |
	| 101 - 500 sqft       |
	| 501 - 1000 sqft      |
	| 1,001 - 5,000 sqft   |
	| 5,001 - 10,000 sqft  |
	| 10,001 - 50,000 sqft |