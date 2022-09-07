Feature: Log in and purchase an item

Background: User logs in
    Given application URL is opened
    And user entered "standard_user" into "Username"
    And user entered "secret_sauce" into "Password"
    When user clicks on "Login button" 

  Scenario: User sees the list of 6 items on the main page
    When user has "6" items in "Inventory List"

  Scenario Outline: User purchases an item (full path)
    Given user clicked on "<itemObject>"
    And the "Shopping cart badge" is visible
    And user clicked on "Shopping cart"
    And the "Inventory Item Name" text is equal to "<itemName>"
    And the "Continue Shopping Button" is visible
    When user clicks on "Checkout Button"
    And user enters the following values into the following controls:
    | value | input             |
    | James | First Name Input  |
    | Black | Last Name Input   |
    | 0958  | Postal Code Input |
    And user clicks on "Continue Button"
    And the "Inventory Item Name" text is equal to "<itemName>"
    And user clicks on "Finish Button"
    Then the following controls should be visible:
    | visibleObjects          |
    | Complete Header         |
    | Back To Products Button |
    And the "Page Title" text should be "Checkout: Complete!"
    Examples: 
    | itemObject              | itemName                |
    | Add Backpack to Cart    | Sauce Labs Backpack     |
    | Add Bike light to Cart  | Sauce Labs Bike Light   |
    | Add Bolt TShirt to Cart | Sauce Labs Bolt T-Shirt |