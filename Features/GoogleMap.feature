Feature: GoogleMap
	Simple calculator for adding two numbers


Scenario: Conntecting cites1
	Given I have browser with google map url
	When i enter cities
		| cities    |
		| bangalore |
		| chennai   |
		| hyd       |
		| delhi     |
		| guj       |
	Then I should get the km connecting all cities 

	@ignore
Scenario: Conntecting cites2
	Given I have browser with google map url
	When i enter cities
		| cities    |
		| bangalore |
		| chennai   |
		| hyd       |
		| delhi     |
		| guj       |
	Then I should get the km connecting all cities 