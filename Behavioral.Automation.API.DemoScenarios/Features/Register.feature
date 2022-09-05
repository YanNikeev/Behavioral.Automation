Feature: Register functionality

  Scenario: 1.1. User registers with valid email and password
    Given user creates a "POST" request to "api/register" url with the json:
    """
    {
    "email": "eve.holt@reqres.in",
    "password": "pistol"
    }
    """
    When user sends request
    And save response json path "$.id" as "userId"
    And user sends a "GET" request to "api/users/" url with "userId" in path
    Then response json path "$.data.email" value should match regex "eve.holt@reqres.in"

  Scenario: 1.2. User tries to register without a password
    Given the response status code should be "400"
    And user creates a "POST" request to "api/register" url with the json:
    """
    {
    "email": "eve.holt@reqres.in",
    "password": ""
    }
    """
    When user sends request
    Then response json path "$..error" value should match regex "Missing password"