using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace selenium_nunit_tests_awala.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;


        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.facebook.com/";

            IWebElement cookieAccept = driver.FindElement(By.XPath("//button[@data-cookiebanner='accept_button']"));
            cookieAccept.Click();

            IWebElement registerButton = driver.FindElement(By.XPath("//a[@data-testid='open-registration-form-button']"));
            registerButton.Click();

            
        }

        [OneTimeTearDown]
        public void Close()
        {
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
