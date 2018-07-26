using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace TestSolution
{
	class TestPage
	{
		IWebDriver driver;

		By inputField = By.Id("new-todo");
		By addedItem = By.CssSelector("ul#todo-list li:last-child label");
		By itemsCounter = By.Id("todo-count");

		public TestPage(IWebDriver driver)
		{
			this.driver = driver;
		}

		public void ProvideTask(string name)
		{
			driver.FindElement(inputField).SendKeys(name);
		} 

		public void PressEnter()
		{
			driver.FindElement(inputField).SendKeys(Keys.Enter);
		}

		public void CheckItemsName(string name)
		{
			var text = driver.FindElement(addedItem).Text;
			Assert.IsTrue(text.Equals(name), String.Format("Item's name mismatch. Expected: {0}. Actual: {1}", name, text));
		}

	}
}
