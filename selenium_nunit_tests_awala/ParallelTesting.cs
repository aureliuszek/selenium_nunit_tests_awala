using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_nunit_tests_awala.BaseClass;
using OpenQA.Selenium.Support.UI;
using selenium_nunit_tests_awala.Utilities;

namespace selenium_nunit_tests_awala
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestLogin1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement usernamePlem = Driver.FindElement(By.Id("user"));
            usernamePlem.SendKeys("Mateusz");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestPassword1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement pwPlem = Driver.FindElement(By.Id("password"));
            pwPlem.SendKeys("Mateusz");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestLogin2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement usernamePlem = Driver.FindElement(By.Id("user"));
            usernamePlem.SendKeys("Mateusz");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestPassword2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement pwPlem = Driver.FindElement(By.Id("password"));
            pwPlem.SendKeys("Mateusz");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestLogin3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement usernamePlem = Driver.FindElement(By.Id("user"));
            usernamePlem.SendKeys("Mateusz");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestPassword3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement pwPlem = Driver.FindElement(By.Id("password"));
            pwPlem.SendKeys("Mateusz");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestLogin4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement usernamePlem = Driver.FindElement(By.Id("user"));
            usernamePlem.SendKeys("Mateusz");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestPassword4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement pwPlem = Driver.FindElement(By.Id("password"));
            pwPlem.SendKeys("Mateusz");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestLogin5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement usernamePlem = Driver.FindElement(By.Id("user"));
            usernamePlem.SendKeys("Mateusz");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestPassword5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement pwPlem = Driver.FindElement(By.Id("password"));
            pwPlem.SendKeys("Mateusz");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestLogin6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement usernamePlem = Driver.FindElement(By.Id("user"));
            usernamePlem.SendKeys("Mateusz");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestPassword6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement pwPlem = Driver.FindElement(By.Id("password"));
            pwPlem.SendKeys("Mateusz");
            Driver.Close();

        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestLogin7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement usernamePlem = Driver.FindElement(By.Id("user"));
            usernamePlem.SendKeys("Mateusz");
            Driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestPassword7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement pwPlem = Driver.FindElement(By.Id("password"));
            pwPlem.SendKeys("Mateusz");
            Driver.Close();

        }


    }
}
