using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace TestSolution
{
    public class TestPage
    {
        private readonly IWebDriver _driver;

        private readonly By _inputField = By.Id("new-todo");
        private readonly By _addedItem = By.CssSelector("ul#todo-list li:last-child label");
        private readonly By _itemsCounter = By.Id("todo-count");

        public TestPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ProvideTask(string name)
        {
            _driver.FindElement(_inputField).SendKeys(name);
        }

        public void PressEnter()
        {
            _driver.FindElement(_inputField).SendKeys(Keys.Enter);
        }

        public void CheckItemsName(string name)
        {
            var text = _driver.FindElement(_addedItem).Text;
            Assert.IsTrue(text.Equals(name), $"Item's name mismatch. Expected: {name}. Actual: {text}");
        }

    }
}
