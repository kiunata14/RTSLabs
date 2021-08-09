using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RTS_Labs_Coding_Exercise
{
    public class GoogleSearchTests
    {
        [Test]
        public void GivenRTSLabsInGoogleSearch_WhenIClickSubmitButton_ThenIClickOnRTSLabsLinkInSearchResult()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com/");
            var searchInput = driver.FindElement(By.Name("q"));
            searchInput.SendKeys("RTS Labs");
            searchInput.Submit();

            driver.FindElementByPartialLinkText("RTS Labs").Click();
           
            Assert.Pass();
        }
    }
}