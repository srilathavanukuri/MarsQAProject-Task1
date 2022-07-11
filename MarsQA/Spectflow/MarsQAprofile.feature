Feature: MarsQAprofile

MarsQA Specflow fature file

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

@AddLanguage
Scenario: C1 Add language of seller in profile details
	Given I login to profile page
	When I click on language tab
	And I add language
	Then I should be able to view edited language record 

@EditLanguage
Scenario: C2 Edit language of seller in profile details
	Given I login to profile page
	When I click on language tab
	And I update language
	Then I should be able to update language sucessfully

@DeleteLanguage
Scenario: C3 Delete language of seller in profile details
	Given I login to profile page
	When I click on language tab
	And I delete the language
	Then I should be able to delete record successfully

@AddSkills
 Scenario: D1 Add Skills of seller in profile details
	Given I login to profile page
	When I click on Skills tab
	And I add Skills
	Then I should be able to view edit skills record

@EditSkills
 Scenario: D2 Edit Skils of seller in the profile details
	Given I login to profile page
	When I click on Skills tab
	And I update Skils
	Then I should be able to update Skills record sucessflly

@DeleteSkils
 Scenario: D3 Delete Skils of seller in profile details
	Given I login to profile page
	When I click on Skills tab
	And I delete  the sklils
	Then I should be able to  delete Skill record  successfully

@AddEducation
Scenario: E1 Add Education of seller in profile details
	Given I login to profile page
	When I click on Education tab
	And I add Education
	Then I should be able to view edit Education record 

@EditEducation
Scenario: E2 Edit Education of seller in profile details
	Given I login to profile page
	When I click on Education tab
	And I update Education
	Then I should be able to Update Education record successfully

@DeleteEducation
Scenario: E3 Delete Education of seller in profile details
	Given I login to profile page
	When I click on Education tab
	And I deleted Education
	Then I should be able to delete record successfuly
	
@AddCertifactions
Scenario: F1 Add Certifications of seller in profile details
	Given I login to profile page
	When I click on Certification tab
	And I can create new certification record
	Then I should be able to view the created Certifcations record 
@EditCertification
Scenario: F2 Edit Certification of seller in profile details
	Given I login to profile page
	When I click on Certification tab
	And I can edit the existing certification record
	Then I should be able to update certification record sucessfully
	
@DeleteCertification
Scenario: F3 Delete Certification of seller in profile details
	Given I login to profile page
	When I click on Certification tab
	And I can delete the existing certification record
	Then I should be able to delete record record sucessfully





