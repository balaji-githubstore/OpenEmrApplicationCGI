using System;
using TechTalk.SpecFlow;

namespace OpenEmrApplication.Steps
{
    [Binding]
    [Scope(Feature = "ChangePassword")]
    public class ChangePasswordSteps
    {
        [When(@"I mouse hover on my Account name")]
        public void WhenIMouseHoverOnMyAccountName()
        {
           
        }
        
        
        [When(@"I click on change password")]
        public void WhenIClickOnChangePassword()
        {
            
        }
        
        [When(@"I enter password as '(.*)'")]
        public void WhenIEnterPasswordAs(string password)
        {
            
        }
    }
}
