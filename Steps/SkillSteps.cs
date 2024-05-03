using AdvancedTaskPart1.AssertHelpers;
using AdvancedTaskPart1.Model;
using AdvancedTaskPart1.Pages.ProfileOverview;
using AdvancedTaskPart1.Pages.SignIn;
using AdvancedTaskPart1.Utilits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Steps
{
    public class SkillSteps
    {
        Login loginObj;
        ProfileMenuTabComponents profileMenuTabComponents;
        SkillComponent skillComponent;
        ProfileSkillOverviewComponent profileSkillOverviewComponent;
        public SkillSteps() 
        {
            loginObj = new Login();
            profileMenuTabComponents = new ProfileMenuTabComponents();
            skillComponent =new SkillComponent();
            profileSkillOverviewComponent= new ProfileSkillOverviewComponent();
        }
        [SetUp]
        public void LoginActions()
        {
            loginObj.LoginActions();
            profileMenuTabComponents.clickSkillTab();
        }
        public void addSkill()
        {
            //Read test data for the add skill testcase
            List<SkillData> skillDataList = JsonReader.LoadData<SkillData>(@"addSkillData.json");
            // Iterate through test data and retrieve AddSkill test data
            foreach(var SkillData in skillDataList)
            {
                profileSkillOverviewComponent.clickAddSkillButton();
                skillComponent.AddSkillsComponent(SkillData);
                Thread.Sleep(1000);
                string actualMessage = skillComponent.getMesssage();
                Console.WriteLine(actualMessage);
                Thread.Sleep(1000);
                SkillAssertHelper.assertAddSkillSucessMessage(SkillData.ExpectedMessage, actualMessage);
                Console.WriteLine(actualMessage);
            }
        }
        //public void updateSkill(int id)
        //{
        //    Read skill data from the specified JSON file and retrieve the item with a matching Id
        //    SkillData existingSkillData = JsonReader.LoadData<SkillData>(@"addSkillData.json").FirstOrDefault(x => x.Id == id);
        //    SkillData newSkillData = JsonReader.LoadData<SkillData>(@"updateSkillData.json").FirstOrDefault(x => x.Id == id);
        //    profileSkillOverviewComponent.clickUpdateSkillButton(existingSkillData);
        //    Console.WriteLine(existingSkillData);
        //    skillComponent.updateSkill(newSkillData);
        //    string actualMessage = skillComponent.getMesssage();
        //    Console.WriteLine($"{actualMessage}");
        //    Thread.Sleep(3000);
        //    SkillAssertHelper.assertUpdateSkillSucessMessage(newSkillData.ExpectedMessage, actualMessage);
        //    Console.WriteLine(newSkillData.ExpectedMessage);
        //    Console.WriteLine(actualMessage);
        //}
        public void updateSkill(int id)
        {
            List<SkillData> skillDataList = JsonReader.LoadData<SkillData>(@"updateSkillData.json");
            foreach(var SkillData in skillDataList)
            {
                profileSkillOverviewComponent.clickUpdateSkillButton(SkillData);
                skillComponent.updateSkill(SkillData);  
                Thread.Sleep(1000);
                String actualMessage=skillComponent.getMesssage();
                SkillAssertHelper.assertUpdateSkillSucessMessage(SkillData.ExpectedMessage,actualMessage);
                Console.WriteLine(actualMessage);
            }
        }

        public void emptySkill()
        {
            // Read test data for the emptySkill test case
            List<SkillData> skillDataList = JsonReader.LoadData<SkillData>(@"emptySkillData.Json");
            // Iterate through test data and retrieve EmptySkill test data
            foreach (var SkillData in skillDataList)
            {
                profileSkillOverviewComponent.clickAddSkillButton();
                skillComponent.AddSkillsComponent(SkillData);
                string actualMessage = skillComponent.getMesssage();
                SkillAssertHelper.assertEmptySkillSucessMessage(SkillData.ExpectedMessage, actualMessage);
                Console.WriteLine(actualMessage);
            }
        }
        public void duplicateAddSkill()
        {
            // Read test data for the existsSkill test case
            List<SkillData> skillDataList = JsonReader.LoadData<SkillData>(@"exitsSkillData.json");
            // Iterate through test data and retrieve existsSkill test data
            foreach (var skillData in skillDataList)
            {
                profileSkillOverviewComponent.clickAddSkillButton();
                skillComponent.AddSkillsComponent(skillData);
                string actualMessage = skillComponent.getMesssage();
                SkillAssertHelper.assertExitsSkillSucessMessage(skillData.ExpectedMessage, actualMessage);
                Console.WriteLine(actualMessage);
            }
        }
        public void SpecialCharUpdateSkill()
        {
            // Read test data for the SpecialCharsSkill test case
            List<SkillData> skillDataList = JsonReader.LoadData<SkillData>(@"specialCharsSkillData.json");
            // Iterate through test data and retrieve SpecialCharsSkill test data
            foreach (var skillData in skillDataList)
            {
                profileSkillOverviewComponent.clickAddSkillButton();
                skillComponent.AddSkillsComponent(skillData);
                string actualMessage = skillComponent.getMesssage();
                SkillAssertHelper.assertSpecialCharSkillSucessMessage(skillData.ExpectedMessage, actualMessage);
                Console.WriteLine(actualMessage);
            }
        }
        public void deleteSkill(int id)
        {
            // Read skill data from the specified JSON file and retrieve the item with a matching Id
            SkillData skillData = JsonReader.LoadData<SkillData>(@"deleteSkillData.json").FirstOrDefault(x => x.Id == id);
            profileSkillOverviewComponent.clickDeleteSkillButton(skillData);
            string actualMessage = skillComponent.getMesssage();
            SkillAssertHelper.assertDeleteSkillSucessMessage(skillData.ExpectedMessage, actualMessage);
            Console.WriteLine(actualMessage);
        }
    }
}
