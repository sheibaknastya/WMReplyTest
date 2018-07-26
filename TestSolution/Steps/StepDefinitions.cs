using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;
using TestSolution.Helpers;
using TestSolution.Pages;

namespace TestSolution.Steps
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"I open testing URL")]
        [Given(@"Testing URL is opened")]
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

        [When(@"The user adds '(.*)' as a task")]
        public void WhenAddTask(string name)
        {
            var page = new TestPage(WebDriver.GetDriver());
            page.ProvideTask(name);
            page.PressEnter();
        }

        [Then(@"'(.*)' is added to the list")]
        public void ThenIsAddedToTheList(string name)
        {
            var value = new TestPage(WebDriver.GetDriver()).GetItemsName();

            Assert.IsTrue(value.Equals(name), $"Item's name mismatch. Expected: {name}. Actual: {value}");
        }

        [Then(@"Total tasks counter is '(.*)'")]
        public void ThenTotalTasksCounter(string number)
        {
            var text = new TestPage(WebDriver.GetDriver()).GetItemsNumber();

            Regex reg = new Regex("[0-9]+");
            Match match = reg.Match(text);

            if (match.Success)
            {
                Assert.IsTrue(match.Value.Equals(number), $"Items' number mismatch. Expected: {number}. Actual: {match.Value}");
            }

        }
    }
}
