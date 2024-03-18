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
       
        public void AddEducation()
        {

            Thread.Sleep(6000);
            EducationTab.Click();
            Thread.Sleep(6000);
            AddNewEducation.Click();
            //Check by direct clicking on Add Button
            Add.Click();
            Thread.Sleep(3000);
            //Add University name in the profile
            UniversityName.SendKeys("Chitkara University");
            Thread.Sleep(1000);
            //Add Country name
            Country.SelectByValue("India");
            Thread.Sleep(4000);
            //Add Title Name
            Title.SelectByValue("B.Tech");
            //Add Degree Name
            Degree.SendKeys("CSE");
            Thread.Sleep(1000);
            //Select Year of graduation
            YearOfGraduation.SelectByValue("2016");
            Thread.Sleep(1000);
            Add.Click();
            Thread.Sleep(1000);
            //Click on add new button 
            AddNewEducation.Click();
            // Add College /University name
            UniversityName.SendKeys("Ara College");
            Thread.Sleep(1000);
            //Add Country name
            Country.SelectByValue("New Zealand");
            //Add Title
            Thread.Sleep(4000);
            Title.SelectByValue("M.Tech");
            //Add Degree Name
            Degree.SendKeys("CSE");
            Thread.Sleep(1000);
            //Add year of graduation
            YearOfGraduation.SelectByValue("2019");
            Thread.Sleep(1000);
            Add.Click();
            Thread.Sleep(1000);
            //Validate by adding university and directly click  on add
            Thread.Sleep(1000);
            AddNewEducation.Click();
            Thread.Sleep(1000);
            UniversityName.SendKeys("Ara College");
            //Click on Add Button
            Add.Click();

        }
        public string Validatebyaddingduplicateeducation()
        {
            Thread.Sleep(4000);
            //Click on education tab
            EducationTab.Click();
            Thread.Sleep(2000);
            //click on add new button
            AddNewEducation.Click();
            Thread.Sleep(2000);
            //enter the input in university textbox
            UniversityName.SendKeys("Chitkara University");
            Thread.Sleep(1000);
            //Select value of country from select field
            Country.SelectByValue("India");
            Thread.Sleep(1000);
            //select value of title from select field
            Title.SelectByValue("B.Tech");
            Thread.Sleep(1000);
            //Enter degree value in degree textbox
            Degree.SendKeys("CSE");
            Thread.Sleep(1000);
            //select year of great fron select field
            YearOfGraduation.SelectByValue("2016");
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
        public string ValidateEmptyScenarioWithEnteringsomeField()
        {
            Thread.Sleep(1000);
            EducationTab.Click();
            //validate by filling some values in field and then click on add button
            Thread.Sleep(1000);
            //Click on Add New
            AddNewEducation.Click();    
            Thread.Sleep(1000);
            //Enter value of university name
            UniversityName.SendKeys("Planit");
            Thread.Sleep(1000);
            //Enter value of country
            Country.SelectByValue("New Zealand");
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

