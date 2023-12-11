#using UserStepDefinition;
Feature: UserFeature
As a User Create a profile then add languages,skills
so that recuriter see your  skills and language in dashboard

@tag1
Scenario: Login with Valid Details
	Given Navigate to User Profile Page
	

	Scenario Outline: Add Languages and Skills in the User Profile
	Given I logged into Profile by adding new user details
	When In User Profile under Description tab
	Then Add Language and Skills 
	Then Save the record in the profile

	Scenario Outline: Edit added Languages and Skills in the User Profile
	Given I Logged into Profile by adding new user details
	When In user profile edit added languages and skills
	Then update the languages and skills in the  record

	Scenario Outline: Delete added Language and Skills in the User Profile
	Given I Logged into Profile by adding new user details
	When In user profile delete added languages and Skills
	Then Check Updated language and Skills 

