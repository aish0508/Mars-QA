using AdvancedTaskPart1.Utilits;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V121.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskPart1.Pages.ProfileOverview
{
    public class ProfileMenuTabComponents:CommonDriver
    {
        private IWebElement LanguageTab;
        private IWebElement SkillTab;
        private IWebElement ShareSkill;
        public void renderComponents()
        {
            try
            {


                LanguageTab = dr.FindElement(By.XPath("//a[@data-tab='first']"));
                SkillTab = dr.FindElement(By.XPath("//a[@data-tab='second']"));
                ShareSkill = dr.FindElement(By.XPath("//a[@class='ui basic green button']"));
            }
            catch(Exception ex)  
            {
                Console.WriteLine(ex);
            
            }
        }
        public void clickLanguageTab()
        {
            Wait.WaitToBeClickable(dr, "XPath", "//a[@data-tab='first']", 4);
            renderComponents();
            LanguageTab.Click();
            Thread.Sleep(4000);
        }
        public void clickSkillTab() 
        {
            Wait.WaitToBeClickable(dr, "XPath", "//a[@data-tab='second']", 4);
            renderComponents();
            SkillTab.Click();
            Thread.Sleep(4000);
        }
        public void clickShareSkillButton() 
        {
            Wait.WaitToBeClickable(dr, "XPath", "//a[@class='ui basic green button']", 4);
            renderComponents();
            ShareSkill.Click();
            Thread.Sleep(4000);
        }
    }
}
