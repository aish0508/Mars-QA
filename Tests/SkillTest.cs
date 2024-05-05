﻿using AdvancedTaskPart1.Pages.ProfileOverview;
using AdvancedTaskPart1.Pages.SignIn;
using AdvancedTaskPart1.Steps;
using AdvancedTaskPart1.Utilits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Tests
{
    public class SkillTest:CommonDriver
    {
        Login loginObj;
        ProfileMenuTabComponents profileMenuTabComponents;
        SkillComponent skillComponent;
        SkillSteps skillSteps;

        public SkillTest()
        {
            loginObj = new Login();
            profileMenuTabComponents = new ProfileMenuTabComponents();
            skillComponent = new SkillComponent();
            skillSteps = new SkillSteps();
        }

        [SetUp]
        public void LoginActions()
        {
            loginObj.LoginActions();
            Thread.Sleep(1000);
            profileMenuTabComponents.clickSkillTab();
        }

        [Test, Order(1), Description("This test is deleting all records in skill list")]
        public void Delete_All_Records()
        {
            skillComponent.DeleteAllRecords();
        }

        [Test, Order(2), Description("This test is adding skill in the skill list")]
        public void Add_Skill()
        {
            skillSteps.addSkill();
        }

        [Test, Order(3), Description("This test is updating an existing skill in the skill list")]
        [TestCase(1)]
        public void Update_Skill(int id)
        {
            skillSteps.updateSkill(id);
        }
        
        [Test, Order(4), Description("This test is adding empty textbox in the skill list")]
        public void EmptyTextbox_Skill()
        {
            skillSteps.emptySkill();
        }

        [Test, Order(5), Description("This test is adding exists skill in the skill list")]
        public void Exists_Skill()
        {
            skillSteps.duplicateAddSkill();
        }

        [Test, Order(6), Description("This test is adding special characters in the skill list")]
        public void SpecialCharacters_Skill()
        {
            skillSteps.SpecialCharUpdateSkill();
        }
        [Test, Order(7), Description("This test is deleting an existing skill in the skill list")]
        [TestCase(1)]
        public void Delete_Skill(int id)
        {
            skillSteps.deleteSkill(id);
        }
    }
}