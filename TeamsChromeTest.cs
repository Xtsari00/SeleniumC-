using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    public class TeamsChromeTest : CommonTest
    {

        IWebDriver driver = new ChromeDriver();

       // [SetUp] public void Setup()
       // {
       //     driver.Navigate().GoToUrl("https://teams.microsoft.com/");
       //     //driver.Manage().Window.Maximize();
       //     Thread.Sleep(3000);

       // }
    


       [Test, Category("ChromeTest")]
        public void logInToMS()
        {

            driver.Navigate().GoToUrl("https://teams.microsoft.com/");
            //driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            IWebElement emailField = driver.FindElement(By.Id("i0116"));
            emailField.SendKeys("dlp.automation3@safeticadlptesting.onmicrosoft.com");
            Thread.Sleep(1000);

            IWebElement confirmButon = driver.FindElement(By.Id("idSIButton9"));
            confirmButon.Click();
            Thread.Sleep(1000);

            IWebElement passwordField = driver.FindElement(By.Id("i0118"));
            passwordField.SendKeys("Password.dlp");


            IWebElement signInButton = driver.FindElement(By.Id("idSIButton9"));
            signInButton.Click();
            Thread.Sleep(1000);
           
            driver.FindElement(By.Id("idSIButton9")).Click();



        }

        [Test, Category("ChromeTest")]
        public void sendOneDriveFile()
        {
            Thread.Sleep(20000);
            IWebElement newConversation = driver.FindElement(By.XPath("//*[@id=\"new-post-button\"]"));
            newConversation.Click();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[1]/div/messages-header/div[2]" +
                "/div/message-pane/div/div[3]/new-message/div/div[3]/div[1]/div/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[8]/div/files-with-navigation/div/files-navigation/div/ul/ul/li[3]/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"2B5276B6-3CFA-4EC1-B7E5-E9DDAE84E634_1\"]/div")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[8]/div/files-with-navigation/div/div/div[2]/div/div[3]/button")).Click();
            Thread.Sleep(1000);

            IWebElement dismissButton = driver.FindElement(By.XPath("//*[@id=\"toast-container\"]/div/div/div[2]/div/button[2]"));
            dismissButton.Click();
            Thread.Sleep(1000);

            Console.Write("Sending OneDriver file...\n");
            IWebElement sendButton = driver.FindElement(By.XPath("//*[@id=\"send-message-button\"]/ng-include/svg"));
            sendButton.Click();
            Thread.Sleep(1000); 
            Console.Write("Successfully sent\n");



        }





        //[TearDown]
       // public void TearDown()
       // {
      //      Thread.Sleep(30000);
      //      driver.Quit();
      //  }

        




    }
}
