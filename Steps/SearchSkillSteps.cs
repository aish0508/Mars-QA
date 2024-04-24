using AdvancedTaskPart1.AssertHelpers;
using AdvancedTaskPart1.Model;
using AdvancedTaskPart1.Pages.SignIn;
using AdvancedTaskPart1.Utilits;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Steps
{
    public class SearchSkillSteps:CommonDriver
    {
        SearchSkillComponent searchSkillComponent;

        public SearchSkillSteps()
        {
            searchSkillComponent = new SearchSkillComponent();
        }

        public void searchSkillCategory()
        {
            List<SearchSkillData> searchSkillDataList = JsonReader.LoadData<SearchSkillData>(@"searchSkillData.json");
            foreach (var searchSkillData in searchSkillDataList)
            {
                searchSkillComponent.clickSearchButton(searchSkillData);
                searchSkillComponent.SearchSkillCategory();
                searchSkillComponent.SearchSkillSubcategory();
                List<IWebElement> skillList = searchSkillComponent.getSkillList();
                // Check if the skillList contains elements
                if (skillList.Count > 0)
                {
                    // If the skillList is not empty, each skill is displayed
                    foreach (var skill in skillList)
                    {
                        SearchSkillAssertHelper.assertSkillListNotEmpty(skill.Displayed);
                    }
                }
                else
                {
                    //If the skillList is empty, print a message SkillList is empty
                    SearchSkillAssertHelper.assertSkillListEmpty(skillList);
                    string Message = searchSkillComponent.getMessage();
                    Console.WriteLine(Message);
                }
            }
        }

        public void searchSkillFilters()
        {
            List<SearchSkillData> searchSkillDataList = JsonReader.LoadData<SearchSkillData>(@"searchSkillData.json");
            foreach (var searchSkillData in searchSkillDataList)
            {
                searchSkillComponent.clickSearchButton(searchSkillData);
                searchSkillComponent.SearchSkillFilters();
                List<IWebElement> skillList = searchSkillComponent.getSkillList();
                // Check if the skillList contains elements
                if (skillList.Count > 0)
                {
                    // If the skillList is not empty, each skill is displayed
                    foreach (var skill in skillList)
                    {
                        SearchSkillAssertHelper.assertSkillListNotEmpty(skill.Displayed);
                    }
                }
                else
                {
                    //If the skillList is empty, print a message SkillList is empty
                    SearchSkillAssertHelper.assertSkillListEmpty(skillList);
                    string Message = searchSkillComponent.getMessage();
                    Console.WriteLine(Message);
                }
            }
        }
    }
}
