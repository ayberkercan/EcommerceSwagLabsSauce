using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using SauceEcommerceDemo.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceEcommerceDemo.Pages
{
    class EcommerceUserHomePage
    {
        // I'm throwing the hooks file to IWebdriver
        public IWebDriver driver = Hook.driver;


        /* Page variables */
        IWebElement userName => driver.FindElement(By.XPath("//*[@id=\"user-name\"]"));
        IWebElement password => driver.FindElement(By.XPath("//*[@id=\"password\"]"));
        IWebElement loginButton => driver.FindElement(By.XPath("//*[@id=\"login-button\"]"));

        //variable methods
        public void NavigateToSite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void UserName(string UserName)
        {
            userName.SendKeys(UserName);
            Thread.Sleep(2000);
        }
        public void Password(string passwordNew)
        {
            password.SendKeys(passwordNew);
            Thread.Sleep(2000);
        }
        public void LoginButton()
        {
            loginButton.Click();
            Thread.Sleep(3000);
        }
        public void ClickTheProduct()
        {
            IWebElement clickTheProduct = driver.FindElement(By.XPath("//*[@id=\"item_4_title_link\"]/div"));
            clickTheProduct.Click();
            Thread.Sleep(2000);
        }
        public void ClickTheAddToCart()
        {
            IWebElement clickTheAddToCart = driver.FindElement(By.XPath("//*[@id=\"add-to-cart-sauce-labs-backpack\"]"));
            clickTheAddToCart.Click();
            Thread.Sleep(2000);

        }
        public void ClickTheYourBasket()
        {
            IWebElement clickTheYourBasket = driver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a"));
            clickTheYourBasket.Click();
            Thread.Sleep(2000);
        }
        public void CheckoutButton()
        {
            IWebElement checkoutButton = driver.FindElement(By.Id("checkout"));
            checkoutButton.Click();
            Thread.Sleep(2000);

        }
        public void Firstname(string firstnamee)
        {
            IWebElement firstName = driver.FindElement(By.Id("first-name"));
            firstName.SendKeys(firstnamee);
            Thread.Sleep(2000);

        }
        public void Lastname(string lastnamee)
        {
            IWebElement lastName = driver.FindElement(By.Id("last-name"));
            lastName.SendKeys(lastnamee);
            Thread.Sleep(2000);

        }
        public void PostalCode(string postalcodee)
        {
            IWebElement postalCode = driver.FindElement(By.Id("postal-code"));
            postalCode.SendKeys(postalcodee);
            Thread.Sleep(2000);
        }
        public void Continue()
        {
            IWebElement continune = driver.FindElement(By.Id("continue"));
            continune.Click();
            Thread.Sleep(2000);

        }
        public void FinishButton()
        {
            IWebElement finishButton = driver.FindElement(By.Id("finish"));
            finishButton.Click();
            Thread.Sleep(9000);

            driver.Quit();
        }


    }



}
