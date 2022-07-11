using MarsQA.Profile_Pages;
using MarsQA.Profile_Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Tests
{
    public class ProfileTests : CommonDriver
    {
        //Page Object Initialization
        ProfilePage profilePageObj = new ProfilePage();
        LanguagePage LangPageObj = new LanguagePage();
        SkillsPage  SkillsPageObj = new SkillsPage();
        EducationPage EducationPageObj = new EducationPage();
        CertificationPage CertificationPageObj = new CertificationPage();
    }
}
