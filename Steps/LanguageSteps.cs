using AdvancedTaskPart1.AssertHelpers;
using AdvancedTaskPart1.Model;
using AdvancedTaskPart1.Pages.ProfileOverview;
using AdvancedTaskPart1.Utilits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Steps
{
    public class LanguageSteps:CommonDriver
    {
        ProfileLanguageOverviewComponent profileLanguageOverviewComponent;
        LanguageComponent languageComponent;
        public LanguageSteps()
        {
            profileLanguageOverviewComponent = new ProfileLanguageOverviewComponent();
            languageComponent = new LanguageComponent();
        }  
        public void addLanguage()
        {
            //Read testdata from addlanguage testcases
            List<LanguageData> languageDataList = JsonReader.LoadData<LanguageData>(@"addLanguageData.json");
            //Iterate through test data and retrieve AddLanguage testdata
            foreach(var languageData in languageDataList)
            {
                profileLanguageOverviewComponent.clickAddLanguageButton();
                languageComponent.addLanguage(languageData);
                Thread.Sleep(1000);
                string actualMessage = languageComponent.getMessage();
                Thread.Sleep(1000);
                LanguageAssertHelper.assertAddLanguageSuccessMessage(languageData.ExpectedMessage, actualMessage);
                Console.WriteLine(actualMessage);
            }
        }
        public void DuplicateLanguage()
        {
            List<LanguageData> DuplicateLanguageData = JsonReader.LoadData<LanguageData>(@"exitsLanguageData.json");
            foreach (var languageData in DuplicateLanguageData)
            {
                profileLanguageOverviewComponent.clickAddLanguageButton();
                languageComponent.addLanguage(languageData);
                string actualMessage = languageComponent.getMessage();
                LanguageAssertHelper.assertExistsLanguageSuccessMessage(languageData.ExpectedMessage, actualMessage);
                Console.WriteLine(actualMessage);
            }

        }
        public void emptyLanguage()
        {
            // Read test data for the emptyLanguage test case
            List<LanguageData> languageDataList = JsonReader.LoadData<LanguageData>(@"emptyLanguageData.json");
            // Iterate through test data and retrieve emptyLanguage test data
            foreach (var languageData in languageDataList)
            {
                profileLanguageOverviewComponent.clickAddLanguageButton();
                languageComponent.addLanguage(languageData);
                string actualMessage = languageComponent.getMessage();
                LanguageAssertHelper.assertEmptyLanguageSuccessMessage(languageData.ExpectedMessage, actualMessage);
                Console.WriteLine(actualMessage);
            }
        }
        public void updateLanguage(int id)
        {
            // Read language data from the specified JSON file and retrieve the item with a matching Id
            LanguageData existingLanguageData = JsonReader.LoadData<LanguageData>(@"addLanguageData.json").FirstOrDefault(x => x.Id == id);
            LanguageData newLanguageData = JsonReader.LoadData<LanguageData>(@"updateLanguageData.json").FirstOrDefault(x => x.Id == id);
            profileLanguageOverviewComponent.clickUpdateLanguageButton(existingLanguageData);
            languageComponent.updateLanguage(newLanguageData);
            string  actualMessage =languageComponent.getMessage();
            LanguageAssertHelper.assertUpdateLanguageSuccessMessage(newLanguageData.ExpectedMessage, actualMessage);
            Console.WriteLine(actualMessage);
           
        }
        public void specialCharactersLanguage()
        {
            // Read test data for the spacialCharsLanguage test case
            List<LanguageData> languageDataList = JsonReader.LoadData<LanguageData>(@"specialCharsLanguageData.json");
            // Iterate through test data and retrieve spacialCharsLanguage test data
            foreach (var languageData in languageDataList)
            {
                profileLanguageOverviewComponent.clickAddLanguageButton();
                Thread.Sleep(1000);
                languageComponent.addLanguage(languageData);
                Thread.Sleep(2000);
                string actualMessage = languageComponent.getMessage();
                Console.WriteLine(actualMessage);
                Thread.Sleep(1000);
                LanguageAssertHelper.assertSpecialCharsLanguageSuccessMessage(languageData.ExpectedMessage, actualMessage);
                Thread.Sleep(1000);
                Console.WriteLine(actualMessage);
            }
        }
        public void deleteLanguage(int id)
        {
            // Read language data from the specified JSON file and retrieve the item with a matching Id
            LanguageData languageData = JsonReader.LoadData<LanguageData>(@"deleteLanguageData.json").FirstOrDefault(x => x.Id == id);
            profileLanguageOverviewComponent.clickDeleteLanguageButton(languageData);
            string actualMessage = languageComponent.getMessage();
            LanguageAssertHelper.assertDeleteLanguageSuccessMessage(languageData.ExpectedMessage, actualMessage);
            Console.WriteLine(actualMessage);
        }

    }

}
