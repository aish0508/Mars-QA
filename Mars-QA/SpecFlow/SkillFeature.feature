Feature: SkillFeature

As a User Create a Profile then add ,edit and delete Skill so that recuriter see your Skill in the dashboard

@Skill
Scenario: 1. Delete all the skill from the skill list
	Given I Logged into a portal
	When User navigate to Skill Tab
	Then  delete all the skill from the skill list

	 Scenario Outline: 2. Add Skill in a profile
	Given I Logged into a portal
	When User navigate to Skill Tab
	Then Add Skill Including '<SkillName>' , '<SkillType>'
	

 Examples:   
| SkillName           | SkillType    |
| Performance Testing | Beginner     |
| Smoke Testing       | Intermediate |
| API Testing         | Expert       |

Scenario Outline: 3. Verify Empty Scenario with Skill textbox as empty
Given I Logged into a portal
When User navigate to Skill Tab
Then User leaves Skill textbox '<SkillName>' ,'<SkillType>' as empty 


Examples: 
| SkillName | SkillType |
|           | Beginner  |
|           |           |

Scenario Outline: 3.Verify by adding existing skill in the  profile
Given I Logged into a portal
When User navigate to Skill Tab
Then user adding by existing skill including '<SkillName>','<SkillType>'
Then Message '<SkillMessage>' should be display
Examples: 
| SkillName   | SkillType | SkillMessage                                    |
| API Testing | Expert    | This skill is already exist in your skill list. |


 Scenario Outline: 4. Edit the already added Skill field with Valid Inputs 
	 Given I Logged into a portal
	 When User navigate to Skill Tab
	 Then Edit the already added Skill Field including '<SkillName>' ,'<SkillType>' 
	 Then AlertMessage '<MessageWithValidSkill>' should be display 
	 
	
 Examples:
    | SkillName | SkillType | MessageWithValidSkill               |
    | SQL       | Expert    | SQL has been updated to your skills |

	Scenario Outline: 5.Edit the already added skill with Invalid Input
	Given I Logged into a portal
	When  User navigate to Skill Tab
    Then Edit the added skill with invalid inputs including '<InvalidSkillName>' 
	Then Message1 '<MessageWithInvalidSkill>' should be display

	Examples: 
|InvalidSkillName | MessageWithInvalidSkill                 |
|r5676@e          | r5676@e has been updated to your skills |




