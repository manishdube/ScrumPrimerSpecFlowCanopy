[<TechTalk.SpecFlow.Binding>]
module CheckTranslationSteps

open TechTalk.SpecFlow
open NUnit.Framework
open canopy
open System

let [<BeforeScenario>] SetupScenario () =
    configuration.chromeDir <- @"D:\"
    start chrome

let [<Given(@"I am on the home page")>] GivenIAmOnTheHomePage() =
    url "http://www.scrumprimer.org"

let [<When(@"I go to scrum primer overview translation page")>] WhenIGoToScrumPrimerOverviewTranslationPage() =
    click "Translations"

let [<Then>] ``I will see scrum primer overview in (.*)`` (language : string) =
    Assert.AreEqual((element "#overview_pic_1").GetAttribute("href"), @"http://www.scrumprimer.org/overview/" + language + "_scrum_overview1.pdf")
    quit()
