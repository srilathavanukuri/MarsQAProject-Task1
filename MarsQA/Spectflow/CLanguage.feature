Feature: CLanguage

A short summary of the feature

@AddLanguage
Scenario: C1 Add language of seller in profile details
	Given I logged into to Mars Portal
	When I click on language tab
	And I add language
	Then I should be able to view edited language record 

@EditLanguage
Scenario: C2 Edit language of seller in profile details
	Given I logged into to Mars Portal
	When I click on language tab
	And I update language
	Then I should be able to update language sucessfully

@DeleteLanguage
Scenario: C3 Delete language of seller in profile details
	Given I logged into to Mars Portal
	When I click on language tab
	And I delete the language
	Then I should be able to delete record successfully
