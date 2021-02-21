using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_nunit_tests_awala.BaseClass;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace selenium_nunit_tests_awala
{
    [TestFixture]
    public class OrderSkipAttribute
    {

        [Test, Category("OrderSkipAttribute"), Order(2)]
        public void TestAlbiclaChrome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://albicla.com/zarejestruj";
            IWebElement firstnameAlbi = driver.FindElement(By.Id("inputName"));
            firstnameAlbi.SendKeys("Mateusz");
            IWebElement emailAlbi = driver.FindElement(By.Id("inputEmail"));
            emailAlbi.SendKeys("matiziomal@nvidia.exe");
            IWebElement pwAlbi = driver.FindElement(By.XPath("//input[@name='pass']"));
            pwAlbi.SendKeys("parufka");
            IWebElement pw2Albi = driver.FindElement(By.XPath("//input[@name='pass2']"));
            pw2Albi.SendKeys("parufka");
            SelectElement countryAlbi = new SelectElement(driver.FindElement(By.Id("country")));
            countryAlbi.SelectByValue("PL");
            IWebElement osobaAlbi = driver.FindElement(By.Id("type1"));
            osobaAlbi.Click();
            IWebElement regulaminAlbi = driver.FindElement(By.Id("regulamin"));
            regulaminAlbi.Click();
            Thread.Sleep(3000);
            driver.Close();
        }
        [Test, Category("OrderSkipAttribute"), Order(1)]
        public void TestAlbiclaInternetExplorer()
        {
            Assert.Ignore("Explorer sie sypie to dałem asserta");
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://albicla.com/zarejestruj";
            IWebElement firstnameAlbi = driver.FindElement(By.Id("inputName"));
            firstnameAlbi.SendKeys("Mateusz");
            IWebElement emailAlbi = driver.FindElement(By.Id("inputEmail"));
            emailAlbi.SendKeys("matiziomal@nvidia.exe");
            IWebElement pwAlbi = driver.FindElement(By.XPath("//input[@name='pass']"));
            pwAlbi.SendKeys("parufka");
            IWebElement pw2Albi = driver.FindElement(By.XPath("//input[@name='pass2']"));
            pw2Albi.SendKeys("parufka");
            SelectElement countryAlbi = new SelectElement(driver.FindElement(By.Id("country")));
            countryAlbi.SelectByValue("PL");
            IWebElement osobaAlbi = driver.FindElement(By.Id("type1"));
            osobaAlbi.Click();
            IWebElement regulaminAlbi = driver.FindElement(By.Id("regulamin"));
            regulaminAlbi.Click();
            Thread.Sleep(3000);
            driver.Close();
            
        }
        [Test, Category("OrderSkipAttribute"), Order(0)]
        public void TestAlbiclaFirefox()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://albicla.com/zarejestruj";
            IWebElement firstnameAlbi = driver.FindElement(By.Id("inputName"));
            firstnameAlbi.SendKeys("Mateusz");
            IWebElement emailAlbi = driver.FindElement(By.Id("inputEmail"));
            emailAlbi.SendKeys("matiziomal@nvidia.exe");
            IWebElement pwAlbi = driver.FindElement(By.XPath("//input[@name='pass']"));
            pwAlbi.SendKeys("parufka");
            IWebElement pw2Albi = driver.FindElement(By.XPath("//input[@name='pass2']"));
            pw2Albi.SendKeys("parufka");
            SelectElement countryAlbi = new SelectElement(driver.FindElement(By.Id("country")));
            countryAlbi.SelectByValue("PL");
            IWebElement osobaAlbi = driver.FindElement(By.Id("type1"));
            osobaAlbi.Click();
            IWebElement regulaminAlbi = driver.FindElement(By.Id("regulamin"));
            regulaminAlbi.Click();
            Thread.Sleep(3000);
            driver.Close();
        }
    }
}
