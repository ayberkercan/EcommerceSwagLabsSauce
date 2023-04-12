Feature: SauceEcommerce

Sauce Ecoomerce Test Scenario

// Here I write the scenarios that will create the steps 

Scenario: SauceWebSiteUser
	Given the navigete to website "https://www.saucedemo.com/"
	When enter the UserName "standard_user"
	And enter the Password "secret_sauce"
	And enter the LoginButton 
    And    Click the product
    And  Click the AddToCart
     And  Click the YourBasket
	And click the CheckoutButton
     And   enter the FirstName " Selenium"  
	And enter the LastName  "Automation"
	And enter the ZipPostalode "34000"
	And click the continue 
	Then click the Finish


