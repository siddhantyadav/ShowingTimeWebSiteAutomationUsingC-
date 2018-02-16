using OpenQA.Selenium;

namespace ShowingTimeWebsiteAutomation
{
    enum EnquiryFor
    {
        Myself,
        MyOffice,
        MyMLSAssociate,
        Other,
        Empty

    }

    enum ProdOfInt
    {
        ShowingTimeAppointmentCenter,
        ShowingTimefortheMLS,
        ShowingTimeFrontDesk,
        InfoSparksforMLSsorassociations,
        FastStatsforMLSsorassociations,
        SmartChartsforMLSsorassociations,
        MarketViewMLSforMLSsorassociations,
        MarketViewBroker,
        LeadCoordinatorandLeadAlert,
        Other,
        Empty

    }

    enum Roles
    {
        sales_associate,
        ManagerStaffBroker,
        MLSAssociationExecutiveorStaff,
        Homeowner
    }

    enum StateProvinces
    {
        Alberta,
        Alaska,
        Alabama,
        Arkansas,
        Arizona,
        BritishColumbia,
        California,
        Colorado,
        Connecticut,
        DistrictofColumbia,
        Delaware,
        Florida,
        Georgia,
        Hawaii,
        Iowa,
        Idaho,
        Illinois,
        Indiana,
        Kansas,
        Kentucky,
        Louisiana,
        Massachusetts,
        Manitoba,
        Maryland,
        Maine,
        Michigan,
        Minnesota,
        Missouri,
        Mississippi,
        Montana,
        NewBrunswick,
        NorthCarolina,
        NorthDakota,
        Nebraska,
        NewHampshire,
        NewJersey,
        NewfoundlandandLabrador,
        NewMexico,
        NovaScotia,
        Nevada,
        NewYork,
        Ohio,
        Oklahoma,
        Ontario,
        Oregon,
        Pennsylvania,
        Quebec,
        PrinceEdwardIsland,
        RhodeIsland,
        SouthCarolina,
        SouthDakota,
        Saskatchewan,
        Tennessee,
        Texas,
        Utah,
        Virginia,
        Vermont,
        Washington,
        Wisconsin,
        WestVirginia,
        Wyoming


    }


    class CommonProperties
    {


        public static IWebDriver driver { get; set; }

    }
}
