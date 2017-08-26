using CloudPCR2._1_Automation.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPCR2._1_Automation.TestCases
{
    [TestClass]
    public class DriverScenarios : SelectingBrowsers
    {
        [TestInitialize]
        public void StartBrowser()
        {
            string Url = GlobalVariables.URL;

            OpenBrowser("Chrome", Url);
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            driver.Close();
        }

        public PCRVariables SeedData(PCRVariables pcr)
        {
            pcr.IncidentNumber = "1234";
            pcr.DispositionOutcome = "Cancelled";
            return pcr;
        }
    }
}
