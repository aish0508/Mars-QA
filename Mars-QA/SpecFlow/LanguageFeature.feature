Feature: Feature


As a User Create a Profile then add ,edit and delete languages so that recuriter see your languages in the dashboard

@Language

 Scenario Outline: 1. Delete all the language from language list
	 Given I Logged into a portal
	 Then  delete all the languages from the language list 
    
Scenario Outline: 2. Add Languages in a profile
	Given I Logged into a portal
	Then I Clicked On Language Tab and Add Language Including '<LanguageName>' , '<LanguageType>'
	

 Examples:   
| LanguageName | LanguageType | 
| Hindi        | Fluent       | 
| Spanish      | Basic        |
| English      | Fluent       | 

Scenario Outline: 3. Verify Empty Scenario with language textbox as empty
Given I Logged into a portal
When User leaves language textbox including  '<LanguageName>' ,'<LanguageType>' as empty 


Examples: 
| LanguageName | LanguageType | 
|              | Fluent       |
|              |              |          
            
                      


Scenario Outline: 4.Verify by adding existing Language  in the  profile
Given I Logged into a portal
When user adding by existing language including '<LanguageName>','<LanguageType>' 
Then DuplicateMessage '<LangMessage>' should be display
Examples: 
| LanguageName | LanguageType | SkillName   | SkillType | LangMessage                                           |
| English      | Fluent       | API Testing | Expert    | This language is already exist in your language list. |

 
	 Scenario Outline: 5. Edit the already added Language field with Valid Inputs 
	 Given I Logged into a portal
	 When Edit the already added Language  Field including '<LanguageName>' ,'<LanguageType>'
	 Then Edit_AlertMessage '<MessageWithValidLang>' should be display 
	 
	 

 Examples:
    | LanguageName | LanguageType | SkillName | SkillType | MessageWithValidLang                      |
    | French       | Basic        | SQL       | Expert    | French has been updated to your languages |
	
	Scenario Outline: 6.Edit the already added language with Invalid Input
	Given I Logged into a portal
    When Edit the added language with invalid inputs including '<InvalidLanguageName>' 
	Then EditMessage '<MessageWithInvalidLang>'  should be display

	Examples: 
| InvalidLanguageName       | InvalidSkillName | MessageWithInvalidLang                                            |
| D344@rfgd$dtereere+=reer3 | r5676@e          | D344@rfgd$dtereerereer35464533 has been updated to your languages |

 
	 
	






	
	  

	