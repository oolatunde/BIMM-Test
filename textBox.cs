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
      
      driver.Url = "https://demoqa.com/text-box";
   
      driver.FindElement(By.Id("userName")).SendKeys("Username");
      driver.FindElement(By.Id("userEmail")).SendKeys("Email");
      driver.FindElement(By.Id("currentAddress")).SendKeys("Address");
      driver.FindElement(By.Id("permanentAddress")).SendKeys(" Permanent Address");
      driver.FindElement(By.Id("submit")).Click();

      WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

     //user info displays after submit, confirming only username
      var name = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("name")));

      name.Text.Should().Contain("Username");

    }

  }
}
