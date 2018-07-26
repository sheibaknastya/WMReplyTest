using TechTalk.SpecFlow;

namespace TestSolution
{
	[Binding]
    public class StepDefinitions
    {
        [Given(@"I open testing URL")]
        public void GivenIOpenProvidedURL()
        {
			WebDriver.GetDriver().Navigate().GoToUrl("http://todomvc.com/examples/angularjs/#/");
        }
        
        [When(@"I add '(.*)' as a task")]
        public void WhenIProvideAsTheInput(string name)
        {
			new TestPage(WebDriver.GetDriver()).ProvideTask(name);
        }
        
        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
			new TestPage(WebDriver.GetDriver()).PressEnter();
		}

		[Then(@"'(.*)' is added to the list")]
        public void ThenIsAddedToTheList(string name)
        {
			new TestPage(WebDriver.GetDriver()).CheckItemsName(name);
        }
    }
}
