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
    public class Edit : CommonDriver
    {
        public IWebElement Educationtab => dr.FindElement(By.XPath("//a[@data-tab='third']"));
        public IWebElement EducationEditIcon => dr.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[6]/span[1]"));
        public IWebElement UniversityName => dr.FindElement(By.Name("instituteName"));
        public SelectElement Country => new SelectElement(dr.FindElement(By.Name("country")));
        public SelectElement Title => new SelectElement(dr.FindElement(By.XPath("//select[@name='title']")));
        public IWebElement Degree => dr.FindElement(By.Name("degree"));
        public SelectElement YearOfGraduation => new SelectElement(dr.FindElement(By.Name("yearOfGraduation")));
        public IWebElement Update => dr.FindElement(By.XPath("//input[@value='Update']"));
        public IWebElement messageAlert => dr.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        private IWebElement CancelButton => dr.FindElement(By.XPath("//div[@class='four wide column' and h3='Education']/following-sibling::div[@class='twelve wide column scrollTable']//input[@value='Cancel']"));

        public void EditEducation()
        {
            Thread.Sleep(4000);
            //click on education tab
            Educationtab.Click();
            Thread.Sleep(1000);
            //click on editIcon
            EducationEditIcon.Click();
            Thread.Sleep(1000);
            //Clear university name 
            UniversityName.Clear();
            Thread.Sleep(1000);
            //Edit value of Ara College from Planit 
            UniversityName.SendKeys("Planit College ");
            Thread.Sleep(2000);
            //edit select value from New Zealand to Australia
            Country.SelectByValue("Australia");
            Thread.Sleep(1000);
            //edit select value from M.Tech to M.B.A
            Title.SelectByValue("M.B.A");
            Thread.Sleep(1000);
            //clear degree Input
            Degree.Clear();
            Thread.Sleep(1000);
            //Edit input from ECE to CSE
            Degree.SendKeys("CSE");
            Thread.Sleep(1000);
            //edit select value from 2019 to 2020
            YearOfGraduation.SelectByValue("2020");
            Thread.Sleep(1000);
            //Click on Update Button
            Update.Click();

        }
        public string EditEducationWithInvalid()
        {
            string actualMessage;
            Thread.Sleep(4000);
            //click on education tab
            Educationtab.Click();
            Thread.Sleep(1000);
            //click on editIcon
            EducationEditIcon.Click();
            Thread.Sleep(1000);
            //Clear university name 
            UniversityName.Clear();
            Thread.Sleep(1000);
            //Edit value of Ara College from Planit 
            UniversityName.SendKeys("A3442#$5&**%^$@@@@@$rrtre54tftdtdrererere");
            Thread.Sleep(1000);
            Degree.Clear();
            Degree.SendKeys("454342232323232@@%&*#()");
            Thread.Sleep(1000);
            //Click on Update Button
            Update.Click();
            Thread.Sleep(4000);
            actualMessage = messageAlert.Text;
            Thread.Sleep(1000);
            Console.WriteLine(actualMessage);
            Thread.Sleep(1000);
            return actualMessage;

        }
        public void getCancel()
        {
            try
            {
                //Click the cancel button
                CancelButton.Click();
            }
            catch (NoSuchElementException)
            {
                return;
            }
        }






    }
}
