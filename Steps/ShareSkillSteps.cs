using AdvancedTaskPart1.AssertHelpers;
using AdvancedTaskPart1.Model;
using AdvancedTaskPart1.Pages.SignIn;
using AdvancedTaskPart1.Utilits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Steps
{
    public class ShareSkillSteps:CommonDriver
    {
        AddAndUpdateShareSkillComponents AddAndUpdateShareSkillComponents;
        ShareSkillOverviewComponent shareSkillOverviewComponent;
        public ShareSkillSteps() 
        { 
            AddAndUpdateShareSkillComponents = new AddAndUpdateShareSkillComponents();
            shareSkillOverviewComponent = new ShareSkillOverviewComponent();
        }
        public void addShareSkill(int id)
        {
            ShareSkillData shareSkillData = JsonReader.LoadData<ShareSkillData>(@"ShareSkillData.json").FirstOrDefault(x => x.Id == id);
            shareSkillOverviewComponent.clickShareButton();
            AddAndUpdateShareSkillComponents.addShareSkills(shareSkillData);
            //Check the added shareskill in the list in ManageListings
            shareSkillOverviewComponent.clickManageListing();
            string newTitle = AddAndUpdateShareSkillComponents.getTitle(shareSkillData.Title);
            ShareSkillAssertHelper.assertAddShareSkillSuccessMessage(shareSkillData.Title, newTitle);

        }

        public void updateShareSkill(int id)
        {
            ShareSkillData shareSkillData = JsonReader.LoadData<ShareSkillData>(@"ShareSkillData.json").FirstOrDefault(x => x.Id == id);
            shareSkillOverviewComponent.clickManageListing();
            shareSkillOverviewComponent.clickUpdateButton(shareSkillData);
            Console.WriteLine(shareSkillData);
            AddAndUpdateShareSkillComponents.updateShareSkill(shareSkillData);
            //Check the updated shareskill in the list in ManageListings 
            shareSkillOverviewComponent.clickManageListing();
            string newTitle = AddAndUpdateShareSkillComponents.getTitle(shareSkillData.Title);
            ShareSkillAssertHelper.assertUpdateShareSkillSuccessMessage(shareSkillData.Title, newTitle);
        }

        public void deleteShareSkill(int id)
        {
            ShareSkillData shareSkillData = JsonReader.LoadData<ShareSkillData>(@"ShareSkillData.json").FirstOrDefault(x => x.Id == id);
            shareSkillOverviewComponent.clickManageListing();
            shareSkillOverviewComponent.clickDeleteButton(shareSkillData);
            string actualMessage = AddAndUpdateShareSkillComponents.getMessage();
            ShareSkillAssertHelper.assertDeleteShareSkillSuccessMessage("API Testing has been deleted", actualMessage);
            Console.WriteLine(actualMessage);
        }
    }
}
