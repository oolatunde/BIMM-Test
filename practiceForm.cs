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
      driver.Url = "https://demoqa.com/automation-practice-form";
     
      studentName(); //first name and last name

      driver.FindElement(By.Id("userEmail")).SendKeys("jnopeyemi@gmail.com");

      gender("Male"); //can change parameter to Female or Other.

      driver.FindElement(By.Id("userNumber")).SendKeys("902-XXX-XXX");

      driver.FindElement(By.Id("dateOfBirthInput")).Clear();
      driver.FindElement(By.Id("dateOfBirthInput")).SendKeys("13 Aug 2022");

      driver.FindElement(By.XPath("//*[@id='subjectsInput']")).SendKeys("Testing BIMM");

      //Can click any hobby you prefer by adding ".Click()"
      driver.FindElement(By.Id("hobbies-checkbox-1"));

      driver.FindElement(By.Id("hobbies-checkbox-2"));

      driver.FindElement(By.Id("hobbies-checkbox-3"));

      selectPicture();

      driver.FindElement(By.Id("currentAddress")).SendKeys("Testing Address");

      //dropdown selection
      SelectElement select = new SelectElement(driver.FindElement(By.Id("state")));
      select.SelectByText("NCR");

      SelectElement select = new SelectElement(driver.FindElement(By.Id("city")));
      select.SelectByText("Agra");

      

    }

    
    public static void studentName()
    {
      driver.FindElement(By.Id("firstName")).SendKeys("John");
      driver.FindElement(By.Id("lastName")).SendKeys("Olatunde");
    }

    public static void gender(string genderSelection)
    {
      string value = "";
      if (genderSelection == "Male")
      {
        value = "1";
      }
      else if (genderSelection == "Female")
      {
        value = "2";
      }
      else
      {
        value = "3";
      }
      driver.FindElement(By.Id("gender-radio-" + value)).Click();
    }

    public static void selectPicture()
    {
      var upload = driver.FindElement(By.Id("uploadPicture")).Click();
     // upload.SendKeys("");//path to selected image

    }
    
  }
}
