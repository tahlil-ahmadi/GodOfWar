Feature: Product
	In order to 
	As a Product Management administrator
	I want to be able to manage Products

Scenario: Defining a root Generic Product
	Given I have already defined the following constraints
	| Title       |
	| Taste       |
	| Volume      |
	| Description |
	When I have define a generic product 'Nectar'
	And I have defined the following constraint for it :
	| Title       | Type        | Options                           |
	| Taste       | Selective   | Orange, Apple, Banana, Watermelon |
	| Volume      | NumberRange | 100-3000 cc                       |
	| Description | String      |                                   |
	Then It should be available in the list of generic products
