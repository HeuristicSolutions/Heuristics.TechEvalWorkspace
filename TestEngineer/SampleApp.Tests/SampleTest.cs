using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleApp.Tests
{
    public class Tests
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {

            string currentPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(currentPath + @"\drivers\");
        }

        [Test]
        public void Smoke_test()
        {
            driver.Navigate().GoToUrl("https://localhost:5001");

            Assert.IsTrue(driver.FindElement(By.ClassName("esh-app-wrapper")).Displayed);
        }
    }
}