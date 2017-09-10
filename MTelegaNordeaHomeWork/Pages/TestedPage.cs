using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTelegaNordeaHomeWork.Pages
{
    public class TestedPage
    {
        #region Statics

        public const string Url = "http://ogloszenia.trojmiasto.pl/motoryzacja-sprzedam/";

        #endregion

        #region Properties - Page Object Pattern

        public IWebDriver WebDriver { get; set; }

        [FindsBy(How = How.XPath, Using = "html/body")]
        public IWebElement TestPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='field_marka_chosen']/a/span")]
        public IWebElement Marka { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='field_marka_chosen']/div/div/input")]
        public IWebElement MarkaInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='field_model_chosen']/a/span")]
        public IWebElement Model { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='field_model_chosen']/div/div/input")]
        public IWebElement ModelInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchbox-form']/div[1]/div[3]/ul/li[5]/input[1]")]
        public IWebElement YearFrom { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchbox-form']/div[1]/div[3]/ul/li[9]/div/p/span")]
        public IWebElement MotorType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchbox-form']/div[1]/div[3]/ul/li[9]/div/div/ul/li[4]/label")]
        public IWebElement MotorTypeDiesel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='location_map_selector_1']")]
        public IWebElement MapPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchbox-form']/div[1]/div[5]/ul/li[1]/label[14]")]
        public IWebElement AirConditioning { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchbox-form']/div[2]/input")]
        public IWebElement SearchButton { get; set; }

        #endregion

        #region Constructors and Destructors

        public TestedPage(IWebDriver driver)
        {
            this.WebDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        public MapPage GoToMapPage()
        {
            MapPage.Click();
            return new MapPage(WebDriver);
        }

        public ResultPage SubmitAndGoToResultPage()
        {
            SearchButton.Click();
            return new ResultPage(WebDriver);
        }
    }
}
