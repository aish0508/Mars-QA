#using StepDefinition;
Feature: Feature

As a User Create a profile then add languages,skills
so that recuriter see your  skills and language in dashboard

@tag1
Scenario: 1. Login with valid Details
	Given Navigate to Profile Page
	When In Description tab Add languages and skills
	Then Verify by add duplicate language 

	Scenario Outline:2. Edit the already added Language
Given Navigate to Profile Page
Then In Description tab Edit the language field and Skill field


Scenario Outline: 3.Delete the already added skills
Given Navigate to Profile Page
Then In Skills tab delete the language and skill

