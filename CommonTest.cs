using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;



namespace SeleniumTest
{
    public class CommonTest 
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {

            Logger.Log($"Test Started: {TestContext.CurrentContext.Test.Name}");

        }

        [TearDown]
        public void EndTest()
        {

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Logger.Log($"Test Failed: {TestContext.CurrentContext.Test.Name}");
            }
            else
            {
                Logger.Log($"Test Passed: {TestContext.CurrentContext.Test.Name}");
            }

            Thread.Sleep(10000);
            driver.Quit();


        }
    }
}
