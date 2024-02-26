
Feature: Feature


As a User Create a Profile then add languages, skills so that recuriter see your skills and language
in the dashboard

@LanguageandSkill
Scenario: 1. Add Languages and Skills in a profile
	Given I Logged into a portal
	Then I Clicked On Language Tab and Add Language Including '<LanguageName>' , '<LanguageType>' Afterthat Click on Skill Tab to add skill including '<SkillName>' , '<SkillType>'
	

 Examples:   
| LanguageName | LanguageType | SkillName           | SkillType    |
| Hindi        | Fluent       | Performance Testing | Beginner     |
| Spanish      | Basic        | Smoke Testing       | Intermediate |
| English      | Fluent       | API Testing         | Expert       |

Scenario Outline: 2. Verify Empty Scenario with language textbox and skill textbox as empty
Given I Logged into a portal
When User leaves language textbox including  '<LanguageName>' ,'<LanguageType>' as empty and skill textbox including '<SkillName>','<SkillType>' as empty
#//Then  Message of Language as '<LangMessage>' and Message of Skill as '<SkillMessage>'

Examples: 
| LanguageName | LanguageType | SkillName | SkillType |
|              | Fluent       |           | Expert    |
|              |              |           |           |
            
                      


Scenario Outline: 3.Verify by adding existing Language and  skill in the  profile
Given I Logged into a portal
When user adding by existing language including '<LanguageName>','<LanguageType>' and skill including '<SkillName>','<SkillType>'
Then Message '<LangMessage>' and '<SkillMessage>' should be display
Examples: 
| LanguageName | LanguageType | SkillName   | SkillType | LangMessage                                          | SkillMessage                                   |
| English      | Fluent       | API Testing | Expert    | This language is already exit in your language list. | This skill is already exit in your skill list. |
 
	 Scenario Outline: 4. Edit the already added Language , Skill field with Valid Inputs and Invalid Inputs
	 Given I Logged into a portal
	 Then  Edit the already added Language and Skill Field including '<LanguageName>' ,'<LanguageType>','<SkillName>' ,'<SkillType>' 
	 Then And I attempt to edit with invalid language '<InvalidLanguageName>' and invalid skill '<InvalidSkillName>' 
	 


 Examples:
    | LanguageName | LanguageType | SkillName | SkillType | InvalidLanguageName            | InvalidSkillName |
    | French       | Basic        | SQL       | Expert    | D344@rfgd$dtereere+=reer3 | r666555          |
    


	 
	 Scenario Outline: 5. Delete the already added Skill
	 Given I Logged into a portal
	 Then I delete the selected language and skill
     
	






	
	  

	