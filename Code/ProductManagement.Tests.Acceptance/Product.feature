Feature: Product
	In order to
	As a Product Management administrator
	I want to be able to manage Products

Scenario: Define new product
	Given I have a product called 'Soccer ball' 
	When I register the product
	Then It should be available in the list of system Product Management
	

Scenario: Product parent
	Given I have a product hierarchy
	When I register a product that have ActualProduct parent
	Then system should prevent me to save it
	And show alter that product should have Abstract Product parent

