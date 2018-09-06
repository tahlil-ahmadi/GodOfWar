Feature: Managing Dimensions
	In order to
	As a UOM administrator
	I want to be able to manage dimensions

Scenario: Define new dimension
	Given I have a dimension called 'Length'
	When I register the dimension
	Then It should be appear in the list of dimensions

Scenario: Defining duplicate dimension
	Given I have already defined a dimension called 'Temperature'
	And I have a dimension called 'Temperature'
	When I register the dimension
	Then The system should prevent me from registering the dimension
	And It should warned that the dimension is duplicated