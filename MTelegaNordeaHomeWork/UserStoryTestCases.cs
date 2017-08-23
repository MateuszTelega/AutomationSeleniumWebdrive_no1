// *********************************************************
// Author:  Mateusz Telega
// Date:    2017-08-22
// Project: Nordea Homework - Test Case Automation for given User Story
// Used Technologies:
// - Selenium Webdriver 2.53.0
// - NUnit Framework 3.*
// Tested Stable Environment:
// - Windows 7
// - Visual Studio Community 2015
// - Firefox 46.0
// - Mozilla geckodriver 0.6.2
// *********************************************************

namespace MTelegaNordeaHomeWork
{
    #region Using Libraries

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;

    #endregion

    public class UserStoryTestCases
    {
        #region Statics

        protected const string Url = "http://ogloszenia.trojmiasto.pl/motoryzacja-sprzedam/";

        #endregion

        #region Fields

        protected IWebDriver driver;

        #endregion

        #region Prepare

        [SetUp]
        public void Prepare()
        {
            driver = new FirefoxDriver();
            driver.Url = Url;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        #endregion

        #region TestCases

        [Test]
        public void TestCase2005()
        {
            #region Step1 - Choose Audi from the car list

            driver.FindElement(By.XPath("//*[@id='field_marka_chosen']/a/span")).Click();
            driver.FindElement(By.XPath("//*[@id='field_marka_chosen']/div/div/input")).SendKeys("Audi" + Keys.Enter);

            #endregion

            #region Step2 - Choose A8 as a model

            driver.FindElement(By.XPath("html/body")).SendKeys(Keys.PageDown);
            driver.FindElement(By.XPath("//*[@id='field_model_chosen']/a/span")).Click();
            driver.FindElement(By.XPath("//*[@id='field_model_chosen']/div/div/input")).SendKeys("A8" + Keys.Enter);

            #endregion

            #region Step3 - Choose production year >= 2005

            driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[1]/div[3]/ul/li[5]/input[1]")).SendKeys("2005");

            #endregion

            #region Step4 - Select diesel as a motor type

            driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[1]/div[3]/ul/li[9]/div/p/span")).Click();
            driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[1]/div[3]/ul/li[9]/div/div/ul/li[4]/label")).Click();

            #endregion

            #region Step5 - Select Gdańsk as a search location

            driver.FindElement(By.XPath("//*[@id='location_map_selector_1']")).Click();
            driver.FindElement(By.XPath("//*[@id='location_select_box_1-1']/div[1]/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='location_select_box_1']/div[2]/a")).Click();

            #endregion

            #region Step6 - Choose air conditioning

            driver.FindElement(By.XPath("html/body")).SendKeys(Keys.PageDown);
            driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[1]/div[5]/ul/li[1]/label[14]")).Click();

            #endregion

            #region Step7 - Press search button

            driver.FindElement(By.XPath("html/body")).SendKeys(Keys.PageDown);
            driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[2]/input")).Click();

            #endregion

        }

        [Test]
        public void TestCase2006()
        {
            #region Step1 - Choose Audi from the car list

            driver.FindElement(By.XPath("//*[@id='field_marka_chosen']/a/span")).Click();
            driver.FindElement(By.XPath("//*[@id='field_marka_chosen']/div/div/input")).SendKeys("Audi" + Keys.Enter);

            #endregion

            #region Step2 - Choose A8 as a model

            driver.FindElement(By.XPath("html/body")).SendKeys(Keys.PageDown);
            driver.FindElement(By.XPath("//*[@id='field_model_chosen']/a/span")).Click();
            driver.FindElement(By.XPath("//*[@id='field_model_chosen']/div/div/input")).SendKeys("A8" + Keys.Enter);

            #endregion

            #region Step3 - Choose production year >= 2006

            driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[1]/div[3]/ul/li[5]/input[1]")).SendKeys("2006");

            #endregion

            #region Step4 - Select diesel as a motor type

            driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[1]/div[3]/ul/li[9]/div/p/span")).Click();
            driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[1]/div[3]/ul/li[9]/div/div/ul/li[4]/label")).Click();

            #endregion

            #region Step5 - Select Gdańsk as a search location

            driver.FindElement(By.XPath("//*[@id='location_map_selector_1']")).Click();
            driver.FindElement(By.XPath("//*[@id='location_select_box_1-1']/div[1]/span[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='location_select_box_1']/div[2]/a")).Click();

            #endregion

            #region Step6 - Choose air conditioning

            driver.FindElement(By.XPath("html/body")).SendKeys(Keys.PageDown);
            driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[1]/div[5]/ul/li[1]/label[14]")).Click();

            #endregion

            #region Step7 - Press search button

            driver.FindElement(By.XPath("html/body")).SendKeys(Keys.PageDown);
            driver.FindElement(By.XPath("//*[@id='searchbox-form']/div[2]/input")).Click();

            #endregion

        }

        #endregion

    }
}
