Feature: ValidateSingleUserRegisteration

Scenario: Verify that registered user cannot register again.
Given I am on Buggy Rating Website
When I try to register my self onceagain.
Then Application should not allow that. 