﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TemplateProject.WebTests.Features
{
    using TechTalk.SpecFlow;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class FRSReq5_2OrderCreationDonorCoolerFeature
    {

        private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "OrderCreationDonorCooler.feature"
#line hidden

        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FRS Req 5.2 Order Creation DonorCooler", "\tIn order to order coolers\r\n\tAs a milk bank user\r\n\tI want to be able to order a c" +
                    "ooler along with supplies for a donor", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null)
                        && (testRunner.FeatureContext.FeatureInfo.Title != "FRS Req 5.2 Order Creation DonorCooler")))
            {
                TemplateProject.WebTests.Features.FRSReq5_2OrderCreationDonorCoolerFeature.FeatureSetup(null);
            }
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }

        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("5.2.1.1 Create Add an order")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FRS Req 5.2 Order Creation DonorCooler")]
        public virtual void _5_2_1_1CreateAddAnOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5.2.1.1 Create Add an order", ((string[])(null)));
#line 6
            this.ScenarioSetup(scenarioInfo);
#line 7
            testRunner.Given("Username MbtsMbTester1 logged in with password Prolacta99", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
            testRunner.When("user navigates to add cooler order page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
            testRunner.And("text 60002 entered in Order_DonorID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
            testRunner.And("element with id updateDonorInfo is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
            testRunner.Then("the dropdown MilkBank has selected value Tiny Treasures Milk Bank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
            testRunner.Then("element with id FirstName has value Erin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
            testRunner.Then("element with id LastName has value Povich", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
            testRunner.Then("element with id Street has value 309 Cimarron Valley Trail", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
            testRunner.Then("element with id State has value MO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
            testRunner.Then("element with id ZipCode has value 63385", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
            testRunner.Then("element with id Email has value erinpovich@yahoo.com", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
            testRunner.Then("element with id PhoneNumber has value (314)-803-6875", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
            testRunner.When("value 1 entered in numeric with DoublePumpingKit id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
            testRunner.And("value 1 entered in numeric with 24mmBreastshields id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
            testRunner.And("value 1 entered in numeric with 27mmBreastshields id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
            testRunner.And("value 1 entered in numeric with 30mmBreastshields id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
            testRunner.And("value 1 entered in numeric with 8ozBottlesSet id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
            testRunner.And("value 1 entered in numeric with PersonalFitConnectors id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
            testRunner.And("value 1 entered in numeric with ValvesandMembranes id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
            testRunner.And("value 1 entered in numeric with Membranes id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
            testRunner.And("value 1 entered in numeric with Tubing id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
            testRunner.And("value 1 entered in numeric with Bags id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
            testRunner.And("value 1 entered in numeric with YellowBag id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
            testRunner.And("text Test Note entered in Order_Notes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
            testRunner.And("element with id btnPlaceOrder is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
            testRunner.Then("the page Order/OrderDetail should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("5.2.1.1 The user can enter Donor ID to pre-populate name address email pone Milk " +
            "Bank")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FRS Req 5.2 Order Creation DonorCooler")]
        public virtual void _5_2_1_1TheUserCanEnterDonorIDToPre_PopulateNameAddressEmailPoneMilkBank()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5.2.1.1 The user can enter Donor ID to pre-populate name address email pone Milk " +
                    "Bank", ((string[])(null)));
#line 34
            this.ScenarioSetup(scenarioInfo);
#line 35
            testRunner.Given("Username MbtsMbTester1 logged in with password Prolacta99", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
            testRunner.When("user navigates to add cooler order page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
            testRunner.And("text 60002 entered in Order_DonorID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
            testRunner.And("element with id updateDonorInfo is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
            testRunner.Then("the dropdown MilkBank has selected value Tiny Treasures Milk Bank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
            testRunner.Then("element with id FirstName has value Erin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
            testRunner.Then("element with id LastName has value Povich", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
            testRunner.Then("element with id Street has value 309 Cimarron Valley Trail", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
            testRunner.Then("element with id State has value MO", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
            testRunner.Then("element with id ZipCode has value 63385", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
            testRunner.Then("element with id Email has value erinpovich@yahoo.com", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
            testRunner.Then("element with id PhoneNumber has value (314)-803-6875", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("5.2.1.1.2 If no Donor ID is entered, user can manually enter name address email p" +
            "hone Milk Bank.")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FRS Req 5.2 Order Creation DonorCooler")]
        public virtual void _5_2_1_1_2IfNoDonorIDIsEnteredUserCanManuallyEnterNameAddressEmailPhoneMilkBank_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5.2.1.1.2 If no Donor ID is entered, user can manually enter name address email p" +
                    "hone Milk Bank.", ((string[])(null)));
#line 48
            this.ScenarioSetup(scenarioInfo);
#line 49
            testRunner.Given("Username MbtsMbTester1 logged in with password Prolacta99", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
            testRunner.When("user navigates to add cooler order page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
            testRunner.And("dropdown with id MilkBank value Texas Childrens Hospital Milk Bank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
            testRunner.And("text Joselyn entered in FirstName", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
            testRunner.And("text Fiennes entered in LastName", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
            testRunner.And("text 1234 Jackson Ave entered in Street", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
            testRunner.And("text Los Angeles entered in City", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
            testRunner.And("text CT entered in State", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
            testRunner.And("text 90000 entered in ZipCode", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
            testRunner.And("text jFiennes@pmail.com entered in Email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
            testRunner.And("text (789)-456-1235 entered in PhoneNumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
            testRunner.Then("the dropdown MilkBank has selected value Texas Childrens Hospital Milk Bank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
            testRunner.Then("element with id FirstName has value Joselyn", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
            testRunner.Then("element with id LastName has value Fiennes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
            testRunner.Then("element with id Street has value 1234 Jackson Ave", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
            testRunner.Then("element with id City has value Los Angeles", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
            testRunner.Then("element with id State has value CT", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
            testRunner.Then("element with id ZipCode has value 90000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
            testRunner.Then("element with id Email has value jFiennes@pmail.com", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
            testRunner.Then("element with id PhoneNumber has value (789)-456-1235", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("5.2.1.1.3 Order Date automatically loads the date at the time of order creation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FRS Req 5.2 Order Creation DonorCooler")]
        public virtual void _5_2_1_1_3OrderDateAutomaticallyLoadsTheDateAtTheTimeOfOrderCreation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5.2.1.1.3 Order Date automatically loads the date at the time of order creation", ((string[])(null)));
#line 70
            this.ScenarioSetup(scenarioInfo);
#line 71
            testRunner.Given("Username MbtsMbTester1 logged in with password Prolacta99", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 72
            testRunner.When("user navigates to add cooler order page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
            testRunner.Then("the date field Order_OrderActualDate has current date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("5.2.1.1.4 An option for Yellow Bag Milk")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FRS Req 5.2 Order Creation DonorCooler")]
        public virtual void _5_2_1_1_4AnOptionForYellowBagMilk()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5.2.1.1.4 An option for Yellow Bag Milk", ((string[])(null)));
#line 75
            this.ScenarioSetup(scenarioInfo);
#line 76
            testRunner.Given("Username MbtsMbTester1 logged in with password Prolacta99", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
            testRunner.When("user navigates to add cooler order page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
            testRunner.And("value 1 entered in numeric with YellowBag id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
            testRunner.Then("numeric with id YellowBag has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("5.2.1.1.5 The user shall be able to add supplies & their quantity in the cooler o" +
            "rder")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FRS Req 5.2 Order Creation DonorCooler")]
        public virtual void _5_2_1_1_5TheUserShallBeAbleToAddSuppliesTheirQuantityInTheCoolerOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5.2.1.1.5 The user shall be able to add supplies & their quantity in the cooler o" +
                    "rder", ((string[])(null)));
#line 81
            this.ScenarioSetup(scenarioInfo);
#line 82
            testRunner.Given("Username MbtsMbTester1 logged in with password Prolacta99", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 83
            testRunner.When("user navigates to add cooler order page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
            testRunner.And("value 1 entered in numeric with DoublePumpingKit id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
            testRunner.And("value 1 entered in numeric with 24mmBreastshields id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
            testRunner.And("value 1 entered in numeric with 27mmBreastshields id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
            testRunner.And("value 1 entered in numeric with 30mmBreastshields id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
            testRunner.And("value 1 entered in numeric with 8ozBottlesSet id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
            testRunner.And("value 1 entered in numeric with PersonalFitConnectors id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
            testRunner.And("value 1 entered in numeric with ValvesandMembranes id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
            testRunner.And("value 1 entered in numeric with Membranes id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
            testRunner.And("value 1 entered in numeric with Tubing id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
            testRunner.And("value 1 entered in numeric with Bags id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
            testRunner.And("value 1 entered in numeric with YellowBag id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
            testRunner.Then("numeric with id DoublePumpingKit has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
            testRunner.Then("numeric with id 24mmBreastshields has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
            testRunner.Then("numeric with id 27mmBreastshields has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
            testRunner.Then("numeric with id 30mmBreastshields has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
            testRunner.Then("numeric with id 8ozBottlesSet has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
            testRunner.Then("numeric with id PersonalFitConnectors has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
            testRunner.Then("numeric with id ValvesandMembranes has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
            testRunner.Then("numeric with id Membranes has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
            testRunner.Then("numeric with id Tubing has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
            testRunner.Then("numeric with id Bags has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
            testRunner.Then("numeric with id Tubing has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
            testRunner.Then("numeric with id YellowBag has value 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("5.2.1.1.6\tThe list of supplies will be displayed as a table with all items and qu" +
            "antity field next to each item")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FRS Req 5.2 Order Creation DonorCooler")]
        public virtual void _5_2_1_1_6TheListOfSuppliesWillBeDisplayedAsATableWithAllItemsAndQuantityFieldNextToEachItem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5.2.1.1.6\tThe list of supplies will be displayed as a table with all items and qu" +
                    "antity field next to each item", ((string[])(null)));
#line 108
            this.ScenarioSetup(scenarioInfo);
#line 109
            testRunner.Given("Username MbtsMbTester1 logged in with password Prolacta99", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 110
            testRunner.When("element with id menuOrders is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
            testRunner.And("element with id menuCreateCoolerOrder is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
            testRunner.Then("the page Order/AddCoolerOrder should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("5.2.1.1.7 Notes field shall be present for the user to enter comments for this or" +
            "der")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FRS Req 5.2 Order Creation DonorCooler")]
        public virtual void _5_2_1_1_7NotesFieldShallBePresentForTheUserToEnterCommentsForThisOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5.2.1.1.7 Notes field shall be present for the user to enter comments for this or" +
                    "der", ((string[])(null)));
#line 114
            this.ScenarioSetup(scenarioInfo);
#line 115
            testRunner.Given("Username MbtsMbTester1 logged in with password Prolacta99", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 116
            testRunner.When("user navigates to add cooler order page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 117
            testRunner.And("text Test Note entered in Order_Notes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
            testRunner.Then("element with id Order_Notes has value Test Note", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("5.2.1.1.8 The user can select shipping methods")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FRS Req 5.2 Order Creation DonorCooler")]
        public virtual void _5_2_1_1_8TheUserCanSelectShippingMethods()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5.2.1.1.8 The user can select shipping methods", ((string[])(null)));
#line 120
            this.ScenarioSetup(scenarioInfo);
#line 121
            testRunner.Given("Username MbtsMbTester1 logged in with password Prolacta99", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 122
            testRunner.When("user navigates to add pump supply order page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
            testRunner.Then("dropdown with id Order_ShippingMethod has Ground,Priority Overnight,2 Day,Express" +
                               ",Saturday Delivery,USPS", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
