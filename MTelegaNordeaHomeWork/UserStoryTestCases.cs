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
    using Pages;
    using TestData;
    using Utils;
    #endregion

    [TestFixture]
    public class UserStoryTestCases
    {
        public IWebDriver driver;
        public TestedPage testPage;

        #region Prepare

        [SetUp]
        public void Prepare()
        {
            driver = new FirefoxDriver();
            testPage = new TestedPage(driver);
            testPage.WebDriver.Navigate().GoToUrl(TestedPage.Url);
            testPage.WebDriver.Manage().Window.Maximize();
            testPage.WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        #endregion

        #region TestCases

        [Test]
        public void TestCase2005()
        {
            SearchedCar carData =
                new SearchedCar() { Marka = "Audi", Model = "A8", YearFrom = "2005", MotorType = "diesel", Location = "Gdańsk", AdditionalEquipment = "Klimatyzacja" };

            #region Step1 - Choose Audi from the car list

            testPage.Marka.Click();
            testPage.MarkaInput.SendKeys(carData.Marka + Keys.Enter);
            Assert.AreEqual(testPage.Marka.Text, carData.Marka);

            #endregion

            #region Step2 - Choose A8 as a model

            testPage.TestPage.SendKeys(Keys.PageDown);
            testPage.Model.Click();
            testPage.ModelInput.SendKeys(carData.Model + Keys.Enter);
            Assert.AreEqual(testPage.Model.Text.Substring(0, 2), carData.Model);

            #endregion

            #region Step3 - Choose production year >= 2005

            testPage.YearFrom.SendKeys(carData.YearFrom);

            #endregion

            #region Step4 - Select diesel as a motor type

            testPage.MotorType.Click();
            testPage.MotorTypeDiesel.Click();
            Assert.AreEqual(testPage.MotorTypeDiesel.Text, carData.MotorType);

            #endregion

            #region Step5 - Select Gdańsk as a search location

            MapPage mapPage = testPage.GoToMapPage();
            mapPage.MapPageLocation.Click();
            mapPage.MapPageSubmit.Click();

            #endregion

            #region Step6 - Choose air conditioning

            testPage.TestPage.SendKeys(Keys.PageDown);
            testPage.AirConditioning.Click();
            Assert.AreEqual(testPage.AirConditioning.Text, carData.AdditionalEquipment);

            #endregion

            #region Step7 - Press search button

            testPage.TestPage.SendKeys(Keys.PageDown);
            ResultPage resultPage = testPage.SubmitAndGoToResultPage();

            #endregion

            #region Step8 - Test Result Summary

            Assert.AreEqual(resultPage.ResultsCount.Text, resultPage.expectedResultsCountTC2005);
            Assert.AreEqual(resultPage.ResultTagCarType.Text, resultPage.expectedResultTagCarType);
            Assert.AreEqual(resultPage.ResultTagMarka.Text, resultPage.expectedResultTagMarka);
            Assert.AreEqual(resultPage.ResultTagModel.Text, resultPage.expectedResultTagModel);
            Assert.AreEqual(resultPage.ResultTagYearFrom.Text, resultPage.expectedResultTagYearFromTC2005);
            Assert.AreEqual(resultPage.ResultTagMotorType.Text, resultPage.expectedResultTagMotorType);
            Assert.AreEqual(resultPage.ResultTagLocation.Text, resultPage.expectedResultTagLocation);
            Assert.AreEqual(resultPage.ResultTagAirConditioning.Text, resultPage.expectedResultTagAirConditioning);

            #endregion

        }

        [Test]
        public void TestCase2006()
        {
            SearchedCar carData =
                new SearchedCar() { Marka = "Audi", Model = "A8", YearFrom = "2006", MotorType = "diesel", Location = "Gdańsk", AdditionalEquipment = "Klimatyzacja" };

            #region Step1 - Choose Audi from the car list

            testPage.Marka.Click();
            testPage.MarkaInput.SendKeys(carData.Marka + Keys.Enter);
            Assert.AreEqual(testPage.Marka.Text, carData.Marka);

            #endregion

            #region Step2 - Choose A8 as a model

            testPage.TestPage.SendKeys(Keys.PageDown);
            testPage.Model.Click();
            testPage.ModelInput.SendKeys(carData.Model + Keys.Enter);
            Assert.AreEqual(testPage.Model.Text.Substring(0, 2), carData.Model);

            #endregion

            #region Step3 - Choose production year >= 2006

            testPage.YearFrom.SendKeys(carData.YearFrom);

            #endregion

            #region Step4 - Select diesel as a motor type

            testPage.MotorType.Click();
            testPage.MotorTypeDiesel.Click();
            Assert.AreEqual(testPage.MotorTypeDiesel.Text, carData.MotorType);

            #endregion

            #region Step5 - Select Gdańsk as a search location

            MapPage mapPage = testPage.GoToMapPage();
            mapPage.MapPageLocation.Click();
            mapPage.MapPageSubmit.Click();

            #endregion

            #region Step6 - Choose air conditioning

            testPage.TestPage.SendKeys(Keys.PageDown);
            testPage.AirConditioning.Click();
            Assert.AreEqual(testPage.AirConditioning.Text, carData.AdditionalEquipment);

            #endregion

            #region Step7 - Press search button

            testPage.TestPage.SendKeys(Keys.PageDown);
            ResultPage resultPage = testPage.SubmitAndGoToResultPage();

            #endregion

            #region Step8 - Test Result Summary

            Assert.AreEqual(resultPage.ResultsCount.Text, resultPage.expectedResultsCountTC2006);
            Assert.AreEqual(resultPage.ResultTagCarType.Text, resultPage.expectedResultTagCarType);
            Assert.AreEqual(resultPage.ResultTagMarka.Text, resultPage.expectedResultTagMarka);
            Assert.AreEqual(resultPage.ResultTagModel.Text, resultPage.expectedResultTagModel);
            Assert.AreEqual(resultPage.ResultTagYearFrom.Text, resultPage.expectedResultTagYearFromTC2006);
            Assert.AreEqual(resultPage.ResultTagMotorType.Text, resultPage.expectedResultTagMotorType);
            Assert.AreEqual(resultPage.ResultTagLocation.Text, resultPage.expectedResultTagLocation);
            Assert.AreEqual(resultPage.ResultTagAirConditioning.Text, resultPage.expectedResultTagAirConditioning);

            #endregion

        }

        #endregion

        #region Clean

        [TearDown]
        public void Clean()
        {
            driver.Dispose();
        }

        #endregion
    }
}