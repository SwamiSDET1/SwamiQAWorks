Feature: ContactUs
	As an end user 
	I want a contact us page 
	So that I can find out more about QAWorks exciting services


Background: 
Given I am on the Contact Us Page

@contactUs
Scenario: Valid Submission
	When I send a message "please contact me I want to find out more " as "j.Bloggs6"and with the email address "j.Blogge@qaworks.com" 
	Then the message should be sent successfully

Scenario Outline: Invalid Submission
	When as "<user>" with"<email_address>" I Attempt to send "<message>" without filling in all the required fields
	Then the validation message should be "<name_validation_message>","<email_validation_message >" and "<message_validation>"
	Examples: 
	| user | email_address        | message | name_validation_message | email_validation_message     | message_validation       |
	| Joe  | j.Bloggs@qaworks.com |         |                         |                              | Please type your message |
	|      | j.Bloggs@qaworks.com | message | Your name is required   |                              |                          |
	| Joe  |                      | message |                         | An Email address is required |                          |
	|      |                      |         | Your name is required   | An Email address is required | Please type your message |
	| Joe  | J.Blogss.email       | message |                         | Invalid Email Address        |                          |
