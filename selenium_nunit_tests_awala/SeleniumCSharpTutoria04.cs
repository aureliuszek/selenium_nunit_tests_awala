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
        [TestCaseSource("DataDrivenTesting")]
        public void Selenium(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //  driver.Url = "https://en.wikipedia.org/wiki/Main_Page";
                driver.Url = urlName;
                IWebElement findWiki = driver.FindElement(By.XPath("/html/body/div[5]/div[1]/div[2]/div/form/div/input[1]"));
                //IWebElement findWiki = driver.FindElement(By.XPath("/html/body/div[5]/div[1]/div[2]/div/form/div/input[abcd]"));
                findWiki.SendKeys("Selenium (software)");
                driver.Quit();
            }
            catch(Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\Bartosz\\Desktop\\semestr5\\Testy i kontrola jakości oprogramowania\\selenium1\\selenium_nunit_tests_awala\\selenium_nunit_tests_awala\\Screenshots\\Screenshot1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

            
        }
        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://en.wikipedia.org/wiki/Main_Page");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");

            return list;
        }
        /* [Test]
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
        } */



    }
}
