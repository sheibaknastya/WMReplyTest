using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace TestSolution
{
    public class TestPage
    {
        private IWebDriver _driver;

        private By _inputField = By.Id("new-todo");
        private By _addedItem = By.CssSelector("ul#todo-list li:last-child label");
        private By _itemsCounter = By.Id("todo-count");

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
