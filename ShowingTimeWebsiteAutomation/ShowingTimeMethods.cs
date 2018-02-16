using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ShowingTimeWebsiteAutomation
{
    class ShowingTimeMethods
    {
        public void ToInputText(string element, string locatorType, string inputdata)
        {
            if (locatorType == "Id")
                CommonProperties.driver.FindElement(By.Id(element)).SendKeys(inputdata);
            if (locatorType == "ClassName")
                CommonProperties.driver.FindElement(By.ClassName(element)).SendKeys(inputdata);
            if (locatorType == "TagName")
                CommonProperties.driver.FindElement(By.TagName(element)).SendKeys(inputdata);
            if (locatorType == "Name")
                CommonProperties.driver.FindElement(By.Name(element)).SendKeys(inputdata);
            if (locatorType == "CssSelector")
                CommonProperties.driver.FindElement(By.CssSelector(element)).SendKeys(inputdata);
            if (locatorType == "XPath")
                CommonProperties.driver.FindElement(By.XPath(element)).SendKeys(inputdata);

        }

        public void ToClick(string element, string locatorType)
        {
            if (locatorType == "Id")
                CommonProperties.driver.FindElement(By.Id(element)).Click();
            if (locatorType == "ClassName")
                CommonProperties.driver.FindElement(By.ClassName(element)).Click();
            if (locatorType == "TagName")
                CommonProperties.driver.FindElement(By.TagName(element)).Click();
            if (locatorType == "Name")
                CommonProperties.driver.FindElement(By.Name(element)).Click();
            if (locatorType == "CssSelector")
                CommonProperties.driver.FindElement(By.CssSelector(element)).Click();
            if (locatorType == "XPath")
                CommonProperties.driver.FindElement(By.XPath(element)).Click();
            if (locatorType == "LinkText")
                CommonProperties.driver.FindElement(By.LinkText(element)).Click();
            if (locatorType == "PartialLinkText")
                CommonProperties.driver.FindElement(By.PartialLinkText(element)).Click();

        }
    }
}
