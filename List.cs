using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using UnderTest.Attributes;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace testing
{
  [DebugRunThis]
  internal class TestingBIMMBase
  {
    public static IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
    public static void Main(string[] args)
    {
      
      driver.Url = "https://demoqa.com/sortable";

      IList<IWebElement>allSortable = new List<IWebElement>();
      allSortable = driver.FindElements(By.ClassName("list-group-item list-group-item-action"));

     if (allSortable.Count != 0)
      {
        for(IWebElement singleElement : allSortable)
        {
          console.writeline(singleElement.Text);
        }
      }
    }
  }
}
