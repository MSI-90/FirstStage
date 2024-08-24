using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RiaParse;

internal class Config
{
    IWebDriver? driver = null;
    private string? riaUrl = "https://ria.ru/";
    private int waitForLoading = 5000;
    internal IWebDriver Driver()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl(riaUrl);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(waitForLoading);
        return driver;
    } 
}
