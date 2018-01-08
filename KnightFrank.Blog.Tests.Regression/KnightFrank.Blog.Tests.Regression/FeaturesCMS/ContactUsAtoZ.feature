Feature: ContactUsAtoZ
A series of tests for the new contact us pages for CMS

Background: User has visited the A to Z contact us page on desktop
	Given user has visited Contact Us A to Z page on desktop

Scenario: user should see the page title information
	Then user should see the page title information 
	| pageHead                             | pagePara                                                                 |
	| Knight Frank Offices, United Kingdom | Below is an A-Z list of Knight Frank offices avaliable in United Kingdom |

Scenario: User should see the letters of the alphabet to select an office
	Then user should see the letters of the alphabet to select an office 
	| AlphaLength |
	| 26          |

