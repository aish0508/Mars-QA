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
        

        [Test, Order(2), Description("This test is adding language in the language list")]
        [TestCase(1)]
        [TestCase(2)]
        public void AddandDelete_Language(int id)
        {
            languageComponent.DeleteAllRecords();
            languageSteps.AddAndDeleteLanguage(id);
            
            
        }
        [Test, Order(3), Description("This test is adding empty textbox in the language list")]
        public void EmptyTextbox_Language()
        {
            languageComponent.DeleteAllRecords();
            languageSteps.emptyLanguage();
        }
        [Test, Order(4), Description("This test is adding exists language in the language list")]
        [TestCase(1)]
        public void Exists_Language(int id)
        {
            languageComponent.DeleteAllRecords();
            languageSteps.DuplicateLanguage(id);
        }


        [Test, Order(5), Description("This test is updating an existing language in the language list")]
        [TestCase(1)]
        public void Update_Language(int id)
        {
            languageComponent.DeleteAllRecords();
            languageSteps.updateLanguage(id);
            
        }
                   
       [Test, Order(6), Description("This test is adding special characters in the language list")]
        public void SpecialCharacters_Language()
        {
            languageComponent.DeleteAllRecords();
            languageSteps.specialCharactersLanguage();
        }
        

    }
}

