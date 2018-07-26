using TechTalk.SpecFlow;

namespace TestSolution
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
