Feature: ALoginandprofile

A short summary of the feature

@LoginSuccessful
Scenario: A configuration of successful loging with valid crendentials
	Given Launch MarsQA Portl and Sign in Successfully
	Then I should be able to login successfully.
	
@UpdateUserProfile	
Scenario: B Edit profile details of the seller
	Given Logged into Mars portal successfully
	When Update First Name,Last Name in the profile
	And click Availability, Hours, Earn Target
    Then Profiles details updated successfully
