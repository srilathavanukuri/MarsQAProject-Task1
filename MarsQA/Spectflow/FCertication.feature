Feature: FCertication

A short summary of the feature
@AddCertifactions
Scenario: F1 Add Certifications of seller in profile details
	Given Logged into MARS portal successfully to access CERT tab
	When I click on Certification tab
	And I can create new certification record
	Then I should be able to view the created Certifcations record 
@EditCertification
Scenario: F2 Edit Certification of seller in profile details
	Given Logged into MARS portal successfully to access CERT tab
	When I click on Certification tab
	And I can edit the existing certification record
	Then I should be able to update certification record sucessfully
	
@DeleteCertification
Scenario: F3 Delete Certification of seller in profile details
	Given Logged into MARS portal successfully to access CERT tab
	When I click on Certification tab
	And I can delete the existing certification record
	Then I should be able to delete record record sucessfully