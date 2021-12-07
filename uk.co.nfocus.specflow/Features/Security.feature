Feature: Secure access for adding users
	As an admin user I want only admin users to be able to manage users on
	this system for security.
@tag1
Scenario: Login with valid username and password
	Given I am on the login page
	When I enter a valid username and password
	Then I am logged in
