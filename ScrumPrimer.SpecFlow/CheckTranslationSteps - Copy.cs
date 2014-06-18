using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace ScrumPrimer.SpecFlow
{
    [Binding]
    public class CheckTranslationSteps
    {
        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
        }

        [When(@"I go to scrum primer overview translation page")]
        public void WhenIGoToScrumPrimerOverviewTranslationPage()
        {
        }

        [Then(@"I will see scrum primer overview in zh-cn")]
        public void ThenIWillSeeScrumPrimerOverviewInZh_Cn()
        {
            Assert.AreEqual(1,2);
        }
    }
}
