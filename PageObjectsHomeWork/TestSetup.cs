using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PageObjectsHomeWork
{
    public class LoginPage
    {
        IWebDriver driver;
        By ActivateLoginFormButton = By.XPath("/html/body/div[2]/div[3]/ul[1]/li[2]/a");
        By Username = By.ClassName("width_100");
        By Userpass = By.XPath("(//input[@name='pass'])[2]");
        By LoginButton = By.XPath("//*[@id='FloatLogin']/div/div/form/input[6]");
        By LogOutButton = By.XPath("/html/body/div[2]/div[3]/ul[1]/li[8]/a");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void InputUsername(string login)
        {
            driver.FindElement(Username).SendKeys(login);
        }

        public void InputPassword(string password)
        {
            driver.FindElement(Userpass).SendKeys(password);
        }

        public void ClickButton()
        {
            driver.FindElement(ActivateLoginFormButton).Click();
        }

        public void ClickLoginButton()
        {
            driver.FindElement(LoginButton).Click();
        }

        public void ClickLogoutButton()
        {
            driver.FindElement(LogOutButton).Click();
        }
    }
}
