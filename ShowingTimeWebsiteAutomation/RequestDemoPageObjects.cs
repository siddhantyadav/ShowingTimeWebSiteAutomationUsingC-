using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            StateProvinces StateProvinceValue, 
            string zip, 
            string phone, 
            string email, 
            string Inquiring1 = null, 
            string Inquiring2 = null,
            string Inquiring3 = null,
            string Inquiring4 = null,
            string ProductInt1 = null,
            string ProductInt2 = null,
            string ProductInt3 = null,
            string ProductInt4 = null,
            string ProductInt5 = null,
            string ProductInt6 = null,
            string ProductInt7 = null,
            string ProductInt8 = null,
            string ProductInt9 = null,
            string ProductInt10 = null
            )

        {
            RequestDemoFirstName.SendKeys(firstname);

            Thread.Sleep(1000);

            RequestDemoFirstName.SendKeys(lastname);

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

                case default:
                    new SelectElement(RequestDsemoStateProvince).SelectByText(nameof(StateProvinceValue));
                    break;

            }

            
            RequestDemoZip.SendKeys(zip);
            Thread.Sleep(1000);

            RequestDemoPhone.SendKeys(phone);
            Thread.Sleep(1000);

            RequestDemoEmail.SendKeys(email);
            Thread.Sleep(1000);

            if (Inquiring1!=null)
            
                RequestDemoIamEnquiringFor1.Click();
            
            if (Inquiring2!= null)
            
                RequestDemoIamEnquiringFor2.Click();
            
            if (Inquiring3!= null)
            
                RequestDemoIamEnquiringFor3.Click();
            
            if (Inquiring4!= null)

                RequestDemoIamEnquiringFor4.Click();
            
            if (ProductInt1!= null)
            
                RequestDemoPOI1.Click();
            
            if (ProductInt2!= null)
            
                RequestDemoPOI2.Click();
            
            if (ProductInt3!= null)
            
                RequestDemoPOI3.Click();
            
            if (ProductInt4!= null)
            
                RequestDemoPOI4.Click();
            
            if (ProductInt5!= null)
            
                RequestDemoPOI5.Click();
            
            if (ProductInt6!= null)
            
               RequestDemoPOI6.Click();

            if (ProductInt7!= null)

                RequestDemoPOI7.Click();

            if (ProductInt8!= null)

                RequestDemoPOI8.Click();

            if (ProductInt9!= null)

                RequestDemoPOI9.Click();

            if (ProductInt10!= null)

                RequestDemoPOI10.Click();
            Thread.Sleep(3000);

        }
       


    }
}
