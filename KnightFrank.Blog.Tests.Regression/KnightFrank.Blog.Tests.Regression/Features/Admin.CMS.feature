Feature: AdminCMS



Scenario: Create a new user profile on Admin
	Given administrator has logged into admin with Valid Credentials
	| UsernameBetaCMS | PasswordBetaCMS |
	|graeme.dowie@knightfrank.com | broxi123  |
	When administrator selects users from the settings drop down
		And User selects new user
		And administrator enters new credentials
		| NewUSerCMSEmail                   | NewUserCMSPassword | NewUserCMSConfirmPassword |
		| digital@knightfrank.com           | Pa55word           | Pa55word					 |
		And then saves this user account
	Then new user should be visible as an author on user list page

