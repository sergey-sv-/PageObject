using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PageObjectsHomeWork
{
    [TestClass]
    public class LoginToCabinetWithValidData
    {
        [TestMethod]
        public void VerifyLoginToSite()
        {
            
                IWebDriver driver = new ChromeDriver();

                //login with valid username and password 
                driver.Navigate().GoToUrl("http://www.i.ua");
                LoginPage login = new LoginPage(driver);
                login.ClickButton();
                login.InputUsername("Testusr111");
                login.InputPassword("qwerty1234");
                login.ClickLoginButton();
                login.ClickLogoutButton();

                driver.Quit();
        }
    }

    [TestClass]
    public class LoginToCabinetWithInalidData
    {
        [TestMethod]
        public void VerifyLoginToSiteInvalid()
        {
            IWebDriver driver = new ChromeDriver();

            //login with invalid username and password 
            driver.Navigate().GoToUrl("http://www.i.ua");
            LoginPage login = new LoginPage(driver);
            login.ClickButton();
            login.InputUsername("Testusr121");
            login.InputPassword("qwerty1254");
            login.ClickLoginButton();
            login.ClickLogoutButton();

            driver.Quit();

        }
    }
}
