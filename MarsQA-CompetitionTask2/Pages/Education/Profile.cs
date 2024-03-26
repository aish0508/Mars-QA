using MarsQA_CompetitionTask2.Data;
using MarsQA_CompetitionTask2.Utilits;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_CompetitionTask2.Pages.Education
{
    public class Profile : CommonDriver
    {
        string actualMessage;
        string actualMessage1;
        string actualMessage2;
        public IWebElement EducationTab => dr.FindElement(By.XPath("//a[@data-tab='third']"));
        public IWebElement AddNewEducation => dr.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        public IWebElement UniversityName => dr.FindElement(By.Name("instituteName"));
        public SelectElement Country => new SelectElement(dr.FindElement(By.Name("country")));
        public SelectElement Title => new SelectElement(dr.FindElement(By.XPath("//select[@name='title']")));
        public IWebElement Degree => dr.FindElement(By.Name("degree"));
        public SelectElement YearOfGraduation => new SelectElement(dr.FindElement(By.Name("yearOfGraduation")));
        public IWebElement Add => dr.FindElement(By.XPath("//input[@value='Add']"));
        public IWebElement messageAlert => dr.FindElement(By.XPath("/html/body/div[1]/div"));
        public IWebElement messageAlert2 => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        public IWebElement messageAlert1 => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
       
        public void AddEducation(EducationData educationData)
        {

            Thread.Sleep(8000);
            EducationTab.Click();
            Thread.Sleep(6000);
            AddNewEducation.Click();
            //Check by direct clicking on Add Button
            Add.Click();
            Thread.Sleep(3000);
            //Add University name in the profile
            UniversityName.SendKeys(educationData.UniversityName);
            Thread.Sleep(2000);
            //Add Country name
            Country.SelectByValue(educationData.Country);
            Thread.Sleep(4000);
            //Add Title Name
            Title.SelectByValue(educationData.Title);
            //Add Degree Name
            Degree.SendKeys(educationData.Degree);
            Thread.Sleep(2000);
            //Select Year of graduation
            YearOfGraduation.SelectByValue(educationData.YearOfGraduation);
            Thread.Sleep(2000);
            Add.Click();
            
        }
        public string Validatebyaddingduplicateeducation(EducationData educationData)
        {
            Thread.Sleep(4000);
            //Click on education tab
            EducationTab.Click();
            Thread.Sleep(2000);
            //click on add new button
            AddNewEducation.Click();
            Thread.Sleep(4000);
            //enter the input in university textbox
            UniversityName.SendKeys(educationData.UniversityName);
            Thread.Sleep(1000);
            //Select value of country from select field
            Country.SelectByValue(educationData.Country);
            Thread.Sleep(1000);
            //select value of title from select field
            Title.SelectByValue(educationData.Title);
            Thread.Sleep(1000);
            //Enter degree value in degree textbox
            Degree.SendKeys(educationData.Degree);
            Thread.Sleep(1000);
            //select year of great fron select field
            YearOfGraduation.SelectByValue(educationData.YearOfGraduation);
            Thread.Sleep(1000);
            //click on add button
            Add.Click();
            Thread.Sleep(1000);
            //store value of alert
            actualMessage = messageAlert.Text;
            Console.WriteLine(actualMessage);
            return actualMessage;
        }

        public string ValidateEmptyScenario()
        {
            //Validate by directly clicking on add button
            Thread.Sleep(1000);
            //Click on education tab
            EducationTab.Click();
            Thread.Sleep(1000);
            //Click on Add New Button
            AddNewEducation.Click();
            Thread.Sleep(1000);
            //Clickon Add Button
            Add.Click();
            //Storing alert message in actualMessage
            actualMessage2 = messageAlert2.Text;
            Console.WriteLine(actualMessage2);
            return actualMessage2;
        }
        public string ValidateEmptyScenarioWithEnteringsomeField(EducationData educationData)
        {
            Thread.Sleep(4000);
            EducationTab.Click();
            //validate by filling some values in field and then click on add button
            Thread.Sleep(1000);
            //Click on Add New
            AddNewEducation.Click();    
            Thread.Sleep(1000);
            //Enter value of university name
            UniversityName.SendKeys(educationData.UniversityName);
            Thread.Sleep(1000);
            //Enter value of country
            Country.SelectByValue(educationData.Country);
            Thread.Sleep(3000);
            //click on add button
            Add.Click();
            Thread.Sleep(1000);
            //Storing alert message in actualMessage
            actualMessage1 = messageAlert1.Text;
            Console.WriteLine(actualMessage1);
            return actualMessage1;
        }
       

    }


}

