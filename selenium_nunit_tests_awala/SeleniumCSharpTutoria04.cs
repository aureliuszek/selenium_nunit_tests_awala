using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace selenium_nunit_tests_awala
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        [Test]
        [Author("Aureliusz", "aureliusz@wala.com")]
        [Description("Wyszukiwarka na Wikipedii")]
        public void Selenium()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://en.wikipedia.org/wiki/Main_Page";
            IWebElement findWiki = driver.FindElement(By.XPath("/html/body/div[5]/div[1]/div[2]/div/form/div/input[1]"));
            findWiki.SendKeys("Selenium (software)");
            IWebElement clickWiki = driver.FindElement(By.Id("searchButton"));
            clickWiki.Click();
            driver.Quit();
        }
        //static IList DataDrivenTesting() 
       // { 
       // ArrayList list = new ArrayList();
       // list.Add("");


        [Test]
        [Author("Aureliusz", "aureliusz@wala.com")]
        [Description("Wyszukiwarka na Wikipedii")]
        public void NUnit()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://en.wikipedia.org/wiki/Main_Page";
            IWebElement findWiki = driver.FindElement(By.XPath("/html/body/div[5]/div[1]/div[2]/div/form/div/input[1]"));
            findWiki.SendKeys("NUnit");
            IWebElement clickWiki = driver.FindElement(By.Id("searchButton"));
            clickWiki.Click();
            driver.Quit();
        }



    }
}
