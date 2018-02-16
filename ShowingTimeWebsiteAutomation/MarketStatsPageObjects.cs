using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowingTimeWebsiteAutomation
{
    class MarketStatsPageObjects
    {
        public MarketStatsPageObjects()
        {
            PageFactory.InitElements(CommonProperties.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Request Price Quote/Demo")]
        public IWebElement RequestPriceQuotaDemo { get; set; }

        public RequestDemoPageObjects ClickRequestDemo()
        {
            RequestPriceQuotaDemo.Click();
            return new RequestDemoPageObjects();
        }

    }
}
