Feature: UserRegistration

Scenario: Verify User Can Register
Given I am on Buggy Rating Website
When I try to register my self
Then I should be able to successfully registered as a valid user.