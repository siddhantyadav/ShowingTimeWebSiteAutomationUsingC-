using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace ShowingTimeWebsiteAutomation
{
    [TestFixture]
    public class ShowingTime
    {


        

        ShowingTimeMethods STmethods = new ShowingTimeMethods();
        

        [SetUp]
        public void Initialize()
        {
            CommonProperties.driver = new ChromeDriver();
            CommonProperties.driver.Navigate().GoToUrl("http://showingtime.com/");
            CommonProperties.driver.Manage().Window.Maximize();
            Console.WriteLine("Opened the url successfully");
           
        }


        [Test]
        public void ClickShowingOption()
        {
            HomePageObjects Pobjects = new HomePageObjects();
            Pobjects.ShowingOption.Click();
            
//            STmethods.ToClick("/html/body/div[1]/div/div[2]/div[1]/div/div/div[2]/div[1]/ul/li[1]/a", "XPath");
//            Console.WriteLine("Clicked on Showing option successfully");
//            Thread.Sleep(1000);
//;            STmethods.ToClick("logo", "Id");
//            Thread.Sleep(2000);
        }

        [Test]
        public void EnterSubscribeInformation()
        {



            HomePageObjects Pobjects = new HomePageObjects();
            Pobjects.SubscribeToEmails("yadav.siddhant19@gmail.com");

            //Pobjects.InputForSubscriptionEmailId.SendKeys("yadav.siddhant19@gmail.com");
            //Thread.Sleep(2000);
            //Pobjects.SubmitButtonforSubsEmail.Click();
            //Thread.Sleep(1000);

            //Console.WriteLine("Enter subscriber information successfully");
            //STmethods.ToInputText("1413525", "Id", "yadav.siddhant19@gmail.com");
            //Thread.Sleep(2000);
            //STmethods.ToClick("SubmitButton", "Id");
            //Thread.Sleep(2000);
        }

        [Test]
        public void ClickMarketStatsandRequestDemo()
        {

            HomePageObjects Pobjects = new HomePageObjects();
            Pobjects.MarketStats.Click();

            //Pobjects.InputForSubscriptionEmailId.SendKeys("yadav.siddhant19@gmail.com");
            //Thread.Sleep(2000);
            //Pobjects.SubmitButtonforSubsEmail.Click();
            //Thread.Sleep(1000);

            //Console.WriteLine("Enter subscriber information successfully");
            //STmethods.ToInputText("1413525", "Id", "yadav.siddhant19@gmail.com");
            //Thread.Sleep(2000);
            //STmethods.ToClick("SubmitButton", "Id");
            //Thread.Sleep(2000);
        }

        [Test]
        public void ClickRequestDemo()
        {
            HomePageObjects HmObjects = new HomePageObjects();
            RequestDemoPageObjects Pobjects = HmObjects.ClickRequestDemo();

            Pobjects.FillRequestDemoForm("s","s", Roles.Homeowner, "s", "s", StateProvinces.Arizona, "s", "s", "s");

            //Pobjects.InputForSubscriptionEmailId.SendKeys("yadav.siddhant19@gmail.com");
            //Thread.Sleep(2000);
            //Pobjects.SubmitButtonforSubsEmail.Click();
            //Thread.Sleep(1000);

            //Console.WriteLine("Enter subscriber information successfully");
            //STmethods.ToInputText("1413525", "Id", "yadav.siddhant19@gmail.com");
            //Thread.Sleep(2000);
            //STmethods.ToClick("SubmitButton", "Id");
            //Thread.Sleep(2000);
        }


        [TearDown]
        public void Complete()
        {
            CommonProperties.driver.Quit();
            Console.WriteLine("Closing the browser");
        }
    }
}
