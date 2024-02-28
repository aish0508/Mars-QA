
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
| English      | Fluent       | API Testing | Expert    | This language is already exist in your language list. | This skill is already exist in your skill list. |
 
	 Scenario Outline: 4. Edit the already added Language , Skill field with Valid Inputs 
	 Given I Logged into a portal
	 When Edit the already added Language and Skill Field including '<LanguageName>' ,'<LanguageType>'and'<SkillName>' ,'<SkillType>' 
	 Then AlertMessage '<MessageWithValidLang>' and '<MessageWithValidSkill>' should be display 
	 
	 
	 


 Examples:
    | LanguageName | LanguageType | SkillName | SkillType | MessageWithValidLang                      | MessageWithValidSkill               |
    | French       | Basic        | SQL       | Expert    | French has been updated to your languages | SQL has been updated to your skills |
	
	Scenario Outline: 5.Edit the already added language and skill with Invalid Input
	Given I Logged into a portal
    When Edit the added language and skill with invalid inputs including '<InvalidLanguageName>' and '<InvalidSkillName>' 
	Then Message1 '<MessageWithInvalidLang>' and '<MessageWithInvalidSkill>' should be display

	Examples: 
| InvalidLanguageName       | InvalidSkillName | MessageWithInvalidLang                                            | MessageWithInvalidSkill                 |
| D344@rfgd$dtereere+=reer3 | r5676@e          | D344@rfgd$dtereerereer35464533 has been updated to your languages | r5676@e has been updated to your skills |

 
	 Scenario Outline: 6. Delete the already added Skill
	 Given I Logged into a portal
	 Then I delete the selected language and skill
     
	






	
	  

	