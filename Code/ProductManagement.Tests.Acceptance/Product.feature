Feature: Product
	In order to
	As a Product Management administrator
	I want to be able to manage Products

Scenario: Define new product
	Given I have a product called 'Soccer ball'
	When I register the product
	Then It should be available in the list of system Product Management
