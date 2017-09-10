using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTelegaNordeaHomeWork.Pages
{
    public class MapPage
    {
        #region Properties - Page Object Pattern

        public IWebDriver WebDriver { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='location_select_box_1-1']/div[1]/span[1]")]
        public IWebElement MapPageLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='location_select_box_1']/div[2]/a")]
        public IWebElement MapPageSubmit { get; set; }

        #endregion

        #region Constructors and Destructors

        public MapPage(IWebDriver driver)
        {
            this.WebDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion
    }
}
