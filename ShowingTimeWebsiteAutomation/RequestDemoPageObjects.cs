using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace ShowingTimeWebsiteAutomation
{
    class RequestDemoPageObjects
    {

        public RequestDemoPageObjects()
        {
            PageFactory.InitElements(CommonProperties.driver, this);
        }

        [FindsBy(How = How.Id, Using = "edit-submitted-first-name")]
        public IWebElement RequestDemoFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-last-name")]
        public IWebElement RequestDemoLastName { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-my-role")]
        public IWebElement RequestDwemoMyRole { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-company")]
        public IWebElement RequestDemoCompany { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-city")]
        public IWebElement RequestDemoCity { get; set; }
        
        [FindsBy(How = How.Id, Using = "edit-submitted-state-province")]
        public IWebElement RequestDsemoStateProvince { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-zip")]
        public IWebElement RequestDemoZip { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-phone")]
        public IWebElement RequestDemoPhone { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-email")]
        public IWebElement RequestDemoEmail { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-i-am-inquiring-for-1")]
        public IWebElement RequestDemoIamEnquiringFor1 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-i-am-inquiring-for-2")]
        public IWebElement RequestDemoIamEnquiringFor2 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-i-am-inquiring-for-3")]
        public IWebElement RequestDemoIamEnquiringFor3 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-i-am-inquiring-for-4")]
        public IWebElement RequestDemoIamEnquiringFor4 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-select-products-of-interest-1")]
        public IWebElement RequestDemoPOI1 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-select-products-of-interest-2")]
        public IWebElement RequestDemoPOI2 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-select-products-of-interest-3")]
        public IWebElement RequestDemoPOI3 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-select-products-of-interest-4")]
        public IWebElement RequestDemoPOI4 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-select-products-of-interest-5")]
        public IWebElement RequestDemoPOI5 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-select-products-of-interest-6")]
        public IWebElement RequestDemoPOI6 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-select-products-of-interest-7")]
        public IWebElement RequestDemoPOI7 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-select-products-of-interest-8")]
        public IWebElement RequestDemoPOI8 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-select-products-of-interest-9")]
        public IWebElement RequestDemoPOI9 { get; set; }

        [FindsBy(How = How.Id, Using = "edit-submitted-select-products-of-interest-10")]
        public IWebElement RequestDemoPOI10 { get; set; }





        public void FillRequestDemoForm(string firstname, 
            string lastname, 
            Roles roleValue, 
            string company, 
            string city, 
            object StateProvinceValue, 
            string zip, 
            string phone, 
            string email, 
            EnquiryFor Inquiring1 = EnquiryFor.Empty,
            EnquiryFor Inquiring2 = EnquiryFor.Empty,
            EnquiryFor Inquiring3 = EnquiryFor.Empty,
            EnquiryFor Inquiring4 = EnquiryFor.Empty,
            ProdOfInt ProductInt1 = ProdOfInt.Empty,
            ProdOfInt ProductInt2 = ProdOfInt.Empty,
            ProdOfInt ProductInt3 = ProdOfInt.Empty,
            ProdOfInt ProductInt4 = ProdOfInt.Empty,
            ProdOfInt ProductInt5 = ProdOfInt.Empty,
            ProdOfInt ProductInt6 = ProdOfInt.Empty,
            ProdOfInt ProductInt7 = ProdOfInt.Empty,
            ProdOfInt ProductInt8 = ProdOfInt.Empty,
            ProdOfInt ProductInt9 = ProdOfInt.Empty,
            ProdOfInt ProductInt10 = ProdOfInt.Empty
            )

        {
            RequestDemoFirstName.SendKeys(firstname);

            Thread.Sleep(1000);

            RequestDemoLastName.SendKeys(lastname);

            Thread.Sleep(1000);

            if (roleValue == Roles.sales_associate )
                new SelectElement(RequestDwemoMyRole).SelectByText("Sales Associate");

            if (roleValue == Roles.MLSAssociationExecutiveorStaff)
                new SelectElement(RequestDwemoMyRole).SelectByText("Manager/Staff/Broker");

            if (roleValue == Roles.ManagerStaffBroker)
                new SelectElement(RequestDwemoMyRole).SelectByText("mls/association_executive_or_staff");

            if (roleValue == Roles.Homeowner)
                new SelectElement(RequestDwemoMyRole).SelectByText("Homeowner");
            Thread.Sleep(1000);

            RequestDemoCompany.SendKeys(company);
            Thread.Sleep(1000);

            RequestDemoCity.SendKeys(city);
            Thread.Sleep(1000);

            switch (StateProvinceValue)
            {
                case StateProvinces.BritishColumbia:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("British Columbia");
                    break;
                   
                case StateProvinces.DistrictofColumbia:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("District of Columbia");
                    break;

                case StateProvinces.NewBrunswick:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("New Brunswick");
                    break;

                case StateProvinces.NorthCarolina:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("North Carolina");
                    break;

                case StateProvinces.NorthDakota:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("North Dakota");
                    break;
                                    

                case StateProvinces.NewHampshire:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("New Hampshire");
                    break;
                                       

               case StateProvinces.NewJersey:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("New Jersey");
                    break;

                    
               case StateProvinces.NewfoundlandandLabrador:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("Newfoundland and Labrador");
                    break;
                                       

               case StateProvinces.NovaScotia:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("Nova Scotia");
                    break;

                    

                case StateProvinces.NewYork:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("New York");
                    break;

                  
                case StateProvinces.PrinceEdwardIsland:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("Prince Edward Island");
                    break;

                    
                case StateProvinces.RhodeIsland:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("Rhode Island");
                    break;

                   
                case StateProvinces.SouthCarolina:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("South Carolina");
                    break;

                case StateProvinces.SouthDakota:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("South Dakota");
                    break;

                case StateProvinces.WestVirginia:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("West Virginia");
                    break;

                default:
                    new SelectElement(RequestDsemoStateProvince).SelectByText("Arizona");
                    break;

            }

            
            RequestDemoZip.SendKeys(zip);
            Thread.Sleep(1000);

            RequestDemoPhone.SendKeys(phone);
            Thread.Sleep(1000);

            RequestDemoEmail.SendKeys(email);
            Thread.Sleep(1000);

            if (Inquiring1== EnquiryFor.Myself)
            
                RequestDemoIamEnquiringFor1.Click();
            
            if (Inquiring2== EnquiryFor.MyOffice)
            
                RequestDemoIamEnquiringFor2.Click();
            
            if (Inquiring3!= EnquiryFor.MyMLSAssociate)
            
                RequestDemoIamEnquiringFor3.Click();
            
            if (Inquiring4!= EnquiryFor.Other)

                RequestDemoIamEnquiringFor4.Click();
            
            if (ProductInt1== ProdOfInt.ShowingTimeAppointmentCenter)
            
                RequestDemoPOI1.Click();
            
            if (ProductInt2== ProdOfInt.ShowingTimefortheMLS)
            
                RequestDemoPOI2.Click();
            
            if (ProductInt3== ProdOfInt.ShowingTimeFrontDesk)
            
                RequestDemoPOI3.Click();
            
            if (ProductInt4== ProdOfInt.InfoSparksforMLSsorassociations)
            
                RequestDemoPOI4.Click();
            
            if (ProductInt5== ProdOfInt.FastStatsforMLSsorassociations)
            
                RequestDemoPOI5.Click();
            
            if (ProductInt6== ProdOfInt.SmartChartsforMLSsorassociations)
            
               RequestDemoPOI6.Click();

            if (ProductInt7== ProdOfInt.MarketViewMLSforMLSsorassociations)

                RequestDemoPOI7.Click();

            if (ProductInt8== ProdOfInt.MarketViewBroker)

                RequestDemoPOI8.Click();

            if (ProductInt9== ProdOfInt.LeadCoordinatorandLeadAlert)

                RequestDemoPOI9.Click();

            if (ProductInt10== ProdOfInt.Other)

                RequestDemoPOI10.Click();
            Thread.Sleep(3000);

        }
       


    }
}
