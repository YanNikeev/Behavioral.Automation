Feature: Adding to cart and removing from cart items functionality

Background: User logs in
    Given application URL is opened
    And user entered "standard_user" into "Username"
    And user entered "secret_sauce" into "Password"
    When user clicks on "Login button" 

  Scenario: Add items to cart & delete items from cart
    Given user adds the "Sauce Labs Backpack" item from "Items" to the cart
    And user adds the "Sauce Labs Bolt T-Shirt" item from "Items" to the cart
    And user adds the "Sauce Labs Bike Light" item from "Items" to the cart
    When user removes the "Sauce Labs Bolt T-Shirt" item from "Items" from the cart
    And user removes the "Sauce Labs Bike Light" item from "Items" from the cart
    And user removes the "Sauce Labs Backpack" item from "Items" from the cart