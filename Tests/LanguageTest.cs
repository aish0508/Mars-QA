using AdvancedTaskPart1.Pages.ProfileOverview;
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
    [TestFixture]
    public class LanguageTest : CommonDriver
    {
        Login loginObj;
        ProfileMenuTabComponents profileMenuTabComponents;
        ProfileLanguageOverviewComponent profileLanguageOverviewComponent;
        LanguageComponent languageComponent;
        LanguageSteps languageSteps;

        public LanguageTest()
        {
            loginObj = new Login();
            profileMenuTabComponents = new ProfileMenuTabComponents();
            profileLanguageOverviewComponent = new ProfileLanguageOverviewComponent();
            languageComponent = new LanguageComponent();
            languageSteps = new LanguageSteps();
        }
        [SetUp]
        public void LoginActions()
        {
            loginObj.LoginActions();
            Thread.Sleep(1000);
            profileMenuTabComponents.clickLanguageTab();
        }
        [Test, Order(1), Description("This test is deleting all records in language list")]
        public void Delete_All_Records()
        {
            languageComponent.DeleteAllRecords();
        }

        [Test, Order(2), Description("This test is adding language in the language list")]
        public void Add_Language()
        {
            languageSteps.addLanguage();
        }
        [Test, Order(3), Description("This test is adding empty textbox in the language list")]
        public void EmptyTextbox_Language()
        {
            languageSteps.emptyLanguage();
        }
        [Test, Order(4), Description("This test is adding exists language in the language list")]
        public void Exists_Language()
        {
            languageSteps.DuplicateLanguage();
        }


        [Test, Order(5), Description("This test is updating an existing language in the language list")]
        [TestCase(1)]
        public void Update_Language(int id)
        {
            languageSteps.updateLanguage(id);
        }
                   
       [Test, Order(6), Description("This test is adding special characters in the language list")]
        public void SpecialCharacters_Language()
        {
            languageSteps.specialCharactersLanguage();
        }
        [Test, Order(7), Description("This test is deleting an existing language in the language list")]
        [TestCase(1)]
        public void Delete_Language(int id)
        {
            languageSteps.deleteLanguage(id);
        }

    }
}

