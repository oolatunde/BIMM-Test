using OpenQa.Selenium;
using OpenQa.Selenium.Firefox;

namespace ToolsQA
{
    class FirstTest
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.demoqa.com";
        }
    }
}