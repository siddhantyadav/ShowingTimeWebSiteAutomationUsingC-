using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Threading;

namespace ShowingTimeWebsiteAutomation
{
    class HomePageObjects
    {

        public HomePageObjects()
        {
            PageFactory.InitElements(CommonProperties.driver, this);
        }

  
        [FindsBy(How=How.LinkText, Using = "Showings")]
        public IWebElement ShowingOption { get; set; }


        [FindsBy(How = How.Id, Using = "logo")]
        public IWebElement ShowingTimeLogo { get; set; }

        [FindsBy(How = How.Id, Using = "1413525")]
        public IWebElement InputForSubscriptionEmailId { get; set; }

       [FindsBy(How = How.Id, Using = "SubmitButton")]
        public IWebElement SubmitButtonforSubsEmail { get; set; }

        
        [FindsBy(How = How.LinkText, Using = "MarketStats")]
        public IWebElement MarketStats { get; set; }

        [FindsBy(How = How.LinkText, Using = "Request Demo")]
        public IWebElement RequestDemo { get; set; }


        public void SubscribeToEmails(string InputEmail)
          {            
            InputForSubscriptionEmailId.SendKeys(InputEmail);
            Thread.Sleep(1000);
            SubmitButtonforSubsEmail.Click();
            Thread.Sleep(1000);

        }

        public RequestDemoPageObjects ClickRequestDemo()
        {
            RequestDemo.Click();
            return new RequestDemoPageObjects();
        }



    }
}
