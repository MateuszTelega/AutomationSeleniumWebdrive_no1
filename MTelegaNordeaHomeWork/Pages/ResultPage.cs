using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTelegaNordeaHomeWork.Pages
{
    public class ResultPage
    {
        #region Statics

        public readonly string expectedResultsCountTC2005 = "2 ofert";
        public readonly string expectedResultsCountTC2006 = "0 ofert";
        public readonly string expectedResultTagCarType = "Rodzaj: osobowy";
        public readonly string expectedResultTagMarka = "Marka: Audi";
        public readonly string expectedResultTagModel = "Model: A8";
        public readonly string expectedResultTagYearFromTC2005 = "Rok produkcji: od 2005 r.";
        public readonly string expectedResultTagYearFromTC2006 = "Rok produkcji: od 2006 r.";
        public readonly string expectedResultTagMotorType = "Rodzaj paliwa: diesel";
        public readonly string expectedResultTagLocation = "Cały Gdańsk";
        public readonly string expectedResultTagAirConditioning = "Klimatyzacja";

        #endregion

        #region Properties - Page Object Pattern

        public IWebDriver WebDriver { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='wcontent']/div/div[2]/p")]
        public IWebElement ResultsCount { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='wcontent']/div/div[3]/a[1]")]
        public IWebElement ResultTagCarType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='wcontent']/div/div[3]/a[2]")]
        public IWebElement ResultTagMarka { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='wcontent']/div/div[3]/a[3]")]
        public IWebElement ResultTagModel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='wcontent']/div/div[3]/a[4]")]
        public IWebElement ResultTagYearFrom { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='wcontent']/div/div[3]/a[5]")]
        public IWebElement ResultTagMotorType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='wcontent']/div/div[3]/a[6]")]
        public IWebElement ResultTagLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='wcontent']/div/div[3]/a[7]")]
        public IWebElement ResultTagAirConditioning { get; set; }

        #endregion

        #region Constructors and Destructors

        public ResultPage(IWebDriver driver)
        {
            this.WebDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

    }
}
