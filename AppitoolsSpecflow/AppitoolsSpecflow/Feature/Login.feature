Feature: Login
	New user creation and login

@smoke
Scenario: Checking user functionality
	Given opens the application
	And Enter Email and password 
	And Clicks Signin
	When Check user functionality


Scenario: Checking website feature
	Given user opens the application
	And   user check the feature
	When  user tries to open chatbot
	Then  User tries to play video
