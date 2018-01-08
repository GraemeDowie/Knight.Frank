Feature: Video for Residential and Commercial play

Background: User has visited the Knight Frank homepage to play the video
	Given user has visited knight frank homepage to play the video

Scenario: When user is on Residential tab there should be a playable video
	When user selects Residential tab
		And presses the video play icon 
	Then a video should begin to play

Scenario: When user is on Commercial tab there should be a playable video
	When user selects Commercial tab
		And presses the video play icon 
	Then a video should begin to play