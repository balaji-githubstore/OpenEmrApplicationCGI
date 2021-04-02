using System;
using TechTalk.SpecFlow;

namespace OpenEmrApplication.Steps
{
    [Binding]
    public class GoogleMapSteps
    {
        private readonly ScenarioContext scenarioContext;
        private readonly FeatureContext featureContext;

        public GoogleMapSteps(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            if (scenarioContext == null) throw new ArgumentNullException("scenarioContext");
            this.scenarioContext = scenarioContext;
            if (featureContext == null) throw new ArgumentNullException("FeatureContext");
            this.featureContext = featureContext;
        }


        [Given(@"I have browser with google map url")]
        public void GivenIHaveBrowserWithGoogleMapUrl()
        {

        }
        [When(@"i enter cities")]
        public void WhenIEnterCities(Table table)
        {
            scenarioContext.Add("tblcities", table);
            scenarioContext.Add("name", "balaji dinakaran");
            scenarioContext.Add("code", 8005);
        }

        [Then(@"I should get the km connecting all cities")]
        public void ThenIShouldGetTheKmConnectingAllCitiesAs()
        {
            if(scenarioContext.TryGetValue("tblcities",out Table table))
            {
                Console.WriteLine();
            }

            if(scenarioContext.TryGetValue("name",out string myname))
            {
                Console.WriteLine(myname);
            }

            if (scenarioContext.TryGetValue("code", out int code))
            {
                Console.WriteLine(code);
            }
        }

    }
}
