using EasyAutomationFramework;
using OpenQA.Selenium;

var web = new Web();

web.StartBrowser();

web.Navigate("https://google.com");

web.AssignValue(TypeElement.Name, "q", "Hello World!").element.SendKeys(Keys.Enter);

