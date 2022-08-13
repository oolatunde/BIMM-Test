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
      
      driver.Url = "https://demoqa.com/frames";

      driver.SwitchTo().ParentFrame();

      driver.SwitchTo().Frame(driver.FindElement(By.Id("frame1")));
      driver.FindElement(By.Id("sampleHeading")).Text.Contains("This is a sample page");

      driver.SwitchTo().ParentFrame();

      driver.SwitchTo().Frame(driver.FindElement(By.Id("frame2")));
      driver.FindElement(By.Id("sampleHeading")).Text.Contains("This is a sample page");

      driver.SwitchTo().ParentFrame();
      driver.FindElement(By.Id("framesWrapper")).Text.Contains("Sample Iframe page There are 2 iframes in this page.");
    }
  }
}
