using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using StatsRoyale.SeleniumFramework.Pages;

namespace StatsRoyale.SeleniumTests
{
    [TestClass]
    public class CardsTests
    {
        //this is a global variable in which all test methods in this class can use.
        IWebDriver driver;
        [TestMethod]
        public void AssertIceSpiritCardIsOnCardPage()
        {
            //use our Page Map Pattern Classes

            HeaderNav headerNav = new HeaderNav(driver);
            headerNav.GoToCardsPage();




            //we found an element
            //var cardMenu = driver.FindElement(By.CssSelector("a[href='/cards']"));
            //cardMenu.Click();
            ////verify card is on card page
            //var card = driver.FindElement(By.CssSelector("a[href='https://statsroyale.com/card/Ice+Spirit']"));
            //Assert.IsTrue(card.Displayed,"Ice Spirit Card is Not present on the page");

            
        }

        [TestMethod]
        public void AssertIceSpiritCardStatsOnDetailsPage()
        {
            //we found an element
            var cardMenu = driver.FindElement(By.CssSelector("a[href='/cards']"));
            cardMenu.Click();
            //verify card is on card page
          


        }

        [TestInitialize]
        public void Setup()
        {
            //Created a chrome driver and launches chrome
            driver = new ChromeDriver();
            //This will expand the chrome window
            driver.Manage().Window.Maximize();
            //Navigate to the website
            driver.Navigate().GoToUrl("https://statsroyale.com/");

        }

        [TestCleanup]
        public void Teardown()
        {
            //Close all chrome tabs
            driver.Quit();
        }
        
    }
}
