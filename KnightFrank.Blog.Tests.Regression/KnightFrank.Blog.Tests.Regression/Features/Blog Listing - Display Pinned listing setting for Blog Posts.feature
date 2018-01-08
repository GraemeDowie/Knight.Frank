Feature: Blog Listing - Display Pinned listing setting for Blog Posts


Scenario: Blog Listing - Display Pinned listing setting for Blog Posts
	Given user has visited the blog homepage
	Then user should see the first three articles are pinned posts

Scenario: Blog Listing - Display Featured posts
	Given user has visited the blog homepage
	Then user should see four Featured posts in the hero area