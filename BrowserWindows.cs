using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using UnderTest.Attributes;
using OpenQA.Selenium.Chrome;
using FluentAssertions;
using System;
using OpenQA.Selenium.Support.UI;


namespace testing
{
  [DebugRunThis]
  internal class TestingBIMMBase
  {
    public static IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
    public static void Main(string[] args)
    {
      //base url
      driver.Url = "https://demoqa.com/browser-windows";

      driver.FindElement(By.Id("windowButton")).Click();

      //Switch between windows on the page.
      driver.SwitchTo().Window(driver.WindowHandles[1]);
      driver.FindElement(By.Id("sampleHeading")).Text.Should().Be("This is a sample page");

      driver.SwitchTo().Window(driver.WindowHandles[0]); //parent page

    }

 
  }
}
