using TechTalk.SpecFlow;
using TestSolution.Helpers;

namespace TestSolution.Config
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            WebDriver.CreateDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebDriver.QuitDriver();
        }
    }
}
