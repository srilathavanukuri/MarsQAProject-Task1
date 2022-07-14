Feature: EEducation

A short summary of the feature

@AddEducation
Scenario: E1 Add Education of seller in profile details
	Given Login to Mars Portal page successfully
	When I click on Education tab
	And I add Education
	Then I should be able to view edit Education record 

@EditEducation
Scenario: E2 Edit Education of seller in profile details
	Given Login to Mars Portal page successfully
	When I click on Education tab
	And I update Education
	Then I should be able to Update Education record successfully

@DeleteEducation
Scenario: E3 Delete Education of seller in profile details
	Given Login to Mars Portal page successfully
	When I click on Education tab
	And I deleted Education
	Then I should be able to delete record successfuly
