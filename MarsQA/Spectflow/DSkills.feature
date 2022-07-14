Feature: DSkills

A short summary of the feature


@AddSkills
 Scenario: D1 Add Skills of seller in profile details
	Given I login to Mars Portal page
	When I click on Skills tab
	And I add Skills
	Then I should be able to view edit skills record

@EditSkills
 Scenario: D2 Edit Skils of seller in the profile details
	Given I login to Mars Portal page
	When I click on Skills tab
	And I update Skils
	Then I should be able to update Skills record sucessflly

@DeleteSkils
 Scenario: D3 Delete Skils of seller in profile details
	Given I login to Mars Portal page
	When I click on Skills tab
	And I delete  the sklils
	Then I should be able to  delete Skill record  successfully