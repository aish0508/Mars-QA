
Feature: Feature


As a User Create a Profile then add languages, skills so that recuriter see your skills and language
in the dashboard

@LanguageandSkill
Scenario: 1. Add Languages and Skills in a profile
	Given I Logged into a portal
	When I Clicked On Language Tab and Add Language Including '<LanguageName>' , '<LanguageType>' Afterthat Click on Skill Tab to add skill including '<SkillName>' , '<SkillType>'
	Then Verify by adding duplicate Language and see record of language and skill including '<LanguageName>','<LanguageType>' ,'<message>' Created in the profile

 Examples:   
| LanguageName | LanguageType | SkillName           | SkillType |
| English      | Fluent       |                     |           |
| Spanish      | Basic        |                     |           |
| Punjabi      | Fluent       | Performance Testing | Beginner     |
 
	 Scenario Outline: 2. Edit the already added Language , Skill field with Valid Inputs and Invalid Inputs
	 Given I Logged into a portal
	 Then  Edit the already added Language and Skill Field including '<LanguageName>' ,'<LanguageType>','<SkillName>' ,'<SkillType>' 
	 And And I attempt to edit with invalid language '<InvalidLanguageName>' and invalid skill '<InvalidSkillName>' ,'<message>','<message1>'


 Examples:
    | LanguageName       | LanguageType | SkillName | SkillType | InvalidLanguageName | InvalidSkillName |
    | French             | Basic        | SQL       | Expert    | D344                | r666555          |


	 
	 Scenario Outline: 3. Delete the already added Skill
	 Given I Logged into a portal
	 Then I delete the selected language and skill
     





	
	  

	