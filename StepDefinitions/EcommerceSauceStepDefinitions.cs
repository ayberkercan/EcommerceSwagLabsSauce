using SauceEcommerceDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceEcommerceDemo.StepDefinitions
{
    // we write our steps
    [Binding]
    public class SauceUserHomeStepDefinitions
    {
        EcommerceUserHomePage ecommerceUserHomePage = new();

        [Given(@"the navigete to website ""([^""]*)""")]
        public void GivenTheNavigeteToWebsite(string url)
        {
            ecommerceUserHomePage.NavigateToSite(url);
        }

        [When(@"enter the UserName ""([^""]*)""")]
        public void WhenEnterTheUserName(string UserName)
        {
            ecommerceUserHomePage.UserName(UserName);
        }

        [When(@"enter the Password ""([^""]*)""")]
        public void WhenEnterThePassword(string passwordNew)
        {
           ecommerceUserHomePage.Password(passwordNew);
        }

        [When(@"enter the LoginButton")]
        public void ThenEnterTheLoginButton()
        {
            ecommerceUserHomePage.LoginButton();
        }

        [When(@"Click the product")]
        public void WhenClickTheProduct()
        {
            ecommerceUserHomePage.ClickTheProduct();

        }

        [When(@"Click the AddToCart")]
        public void WhenClickTheAddToCart()
        {
            ecommerceUserHomePage.ClickTheAddToCart();
        }

        [When(@"Click the YourBasket")]
        public void WhenClickTheYourBasket()
        {
            ecommerceUserHomePage.ClickTheYourBasket();
        }

        [When(@"click the CheckoutButton")]
        public void ThenClickTheCheckoutButton()
        {
            ecommerceUserHomePage.CheckoutButton();
        }


        [When(@"enter the FirstName ""([^""]*)""")]
        public void WhenEnterTheFirstName(string fiirstname)
        {
            ecommerceUserHomePage.Firstname(fiirstname);
        }

        [When(@"enter the LastName  ""([^""]*)""")]
        public void WhenEnterTheLastName(string automation)
        {
            ecommerceUserHomePage.Lastname(automation);
        }

        [When(@"enter the ZipPostalode ""([^""]*)""")]
        public void WhenEnterTheZipPostalode(string poostalcode)
        {
            ecommerceUserHomePage.PostalCode(poostalcode);
        }

        [When(@"click the continue")]
        public void WhenClickTheContinue()
        {
           ecommerceUserHomePage.Continue();
        }

        [Then(@"click the Finish")]
        public void ThenClickTheFinish()
        {
           ecommerceUserHomePage.FinishButton();
        }





    }
}
