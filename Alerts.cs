using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using UnderTest.Attributes;
using OpenQA.Selenium.Chrome;

namespace testing
{
  [DebugRunThis]
  internal class TestingBIMMBase
  {
    public static IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
    public static void Main(string[] args)
    {
      
      //URL for alerts page
      driver.Url = "https://demoqa.com/alerts";

      //Finds and select OK on the alert button
      driver.FindElement(By.Id("alertButton")).Click();
      IAlert alert = driver.SwitchTo().Alert();
      alert.Accept();

      driver.FindElement(By.Id("confirmButton")).Click();
      IAlert alert2 = driver.SwitchTo().Alert();
      alert2.Dismiss();

      //type testing in the promt alert field
      driver.FindElement(By.Id("promtButton")).Click();
      driver.SwitchTo().Alert().SendKeys("Testing");
      
    }
  }
}
