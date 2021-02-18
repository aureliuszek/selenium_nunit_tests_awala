using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_nunit_tests_awala.BaseClass;
using OpenQA.Selenium.Support.UI;

namespace selenium_nunit_tests_awala
{
    [TestFixture]
    public class TestClass : BaseTest
    {

        [Test, Category("Regression Testing"), Order(1)]
        public void FbFirstname()
        {
            IWebElement firstname = driver.FindElement(By.XPath("//input[@name='firstname']"));
            firstname.SendKeys("Mateusz");
        }

        [Test, Category("Smoke Testing"), Order(2)]
        public void FbLastname()
        {
            IWebElement lastname = driver.FindElement(By.XPath("//input[@name='lastname']"));
            lastname.SendKeys("Kowalski");
        }

        [Test, Category("Smoke Testing"), Order(3)]
        public void FbEmail()
        {
            IWebElement email = driver.FindElement(By.XPath("//input[@name='reg_email__']"));
            IWebElement emailConf = driver.FindElement(By.XPath("//input[@name='reg_email_confirmation__']"));
            email.SendKeys($"testing321@gmail.com");
            emailConf.SendKeys($"testing321@gmail.com");
        }

        [Test, Category("Smoke Testing"), Order(4)]
        public void FbPassword()
        {
            IWebElement passw = driver.FindElement(By.XPath("//input[@name='reg_passwd__']"));
            passw.SendKeys("123123123qweqweasdasdzxczxc");
        }

        [Test, Category("Smoke Testing"), Order(5)]
        public void FbBirth()
        {
            SelectElement day = new SelectElement(driver.FindElement(By.XPath("//select[@name='birthday_day']")));
            SelectElement month = new SelectElement(driver.FindElement(By.XPath("//select[@name='birthday_month']")));
            SelectElement year = new SelectElement(driver.FindElement(By.XPath("//select[@name='birthday_year']")));

            day.SelectByValue("26");
            month.SelectByText("sie");
            year.SelectByValue("1997");
        }
        
        [Test, Category("Smoke Testing"), Order(6)]
        public void FbSex()
        {
            IWebElement sexUnknown = driver.FindElement(By.XPath("//input[@name='sex' and @value='-1']"));
            IWebElement sexFemale = driver.FindElement(By.XPath("//input[@name='sex' and @value='1']"));
            IWebElement sexMale = driver.FindElement(By.XPath("//input[@name='sex' and @value='2']"));

            List<IWebElement> selectSex = new List<IWebElement>();
            selectSex.Add(sexUnknown);
            selectSex.Add(sexFemale);
            selectSex.Add(sexMale);

            IWebElement selectedSex = selectSex[(int)2];
            selectedSex.Click();

        }

        
    }
}
