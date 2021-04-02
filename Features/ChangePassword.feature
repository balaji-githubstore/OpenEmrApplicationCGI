@changepassword
Feature: ChangePassword
	In order to manage the complete hospital records
	As a portal user
	I should be able to reset the password

	@ignore
Scenario: Validate Change Password
	Given I have browser with openemr url
	When I mouse hover on my Account name
	And I click on change password
	And I enter password as 'pass'