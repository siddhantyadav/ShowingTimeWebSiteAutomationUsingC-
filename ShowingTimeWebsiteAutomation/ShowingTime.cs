using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;


namespace ShowingTimeWebsiteAutomation
{
    [TestFixture]
    public class ShowingTime
    {


        

               

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
            
        }

        [Test]
        public void EnterSubscribeInformation()
        {



            HomePageObjects Pobjects = new HomePageObjects();
            Pobjects.SubscribeToEmails("yadav.siddhant19@gmail.com");
        }

        [Test]
        public void ClickMarketStatsandRequestDemo()
        {

            HomePageObjects Pobjects = new HomePageObjects();
            Pobjects.MarketStats.Click();
        }

        [Test]
        public void ClickRequestDemo()
        {
            HomePageObjects HmObjects = new HomePageObjects();
            RequestDemoPageObjects Pobjects = HmObjects.ClickRequestDemo();

            Pobjects.FillRequestDemoForm(
                "Siddhant","Yadav", 
                Roles.Homeowner, 
                "Selfowned", 
                "Chicago", 
                StateProvinces.Arizona, 
                "99999", 
                "3339999999", 
                "xyz@gmail.com", 
                EnquiryFor.MyMLSAssociate,
                EnquiryFor.MyOffice, 
                EnquiryFor.Empty, 
                EnquiryFor.Empty, 
                ProdOfInt.Empty, 
                ProdOfInt.Empty, 
                ProdOfInt.Empty,
                ProdOfInt.Empty,
                ProdOfInt.Empty,
                ProdOfInt.SmartChartsforMLSsorassociations,
                ProdOfInt.Empty,
                ProdOfInt.Other,
                ProdOfInt.Empty,
                ProdOfInt.Empty
                );

        }


        [TearDown]
        public void Complete()
        {
            CommonProperties.driver.Quit();
            Console.WriteLine("Closing the browser");
        }
    }
}
