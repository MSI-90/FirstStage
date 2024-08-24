using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Docker.DotNet.Models;

namespace RiaNews;

internal class RiaInfo
{
    IWebDriver driver = new ChromeDriver();
    Driver.Navigate().GoToUrl("https://ria.ru/");

    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
        driver.FindElement(politicCategory).Click();

    var pictureFromCategoryHyperlink = driver.FindElements(hyperlinkItemCategoryImage);
    var titleItemsFromCategoryHyperlink = driver.FindElements(hyperlinkItemCategory);

        if (titleItemsFromCategoryHyperlink.Any())
        {
            var index = 1;
            foreach (var item in titleItemsFromCategoryHyperlink)
            {
                Console.WriteLine(index + ") " + item.GetAttribute("href") + " -- " + item.Text + " " + pictureFromCategoryHyperlink[index - 1].GetAttribute("srcset"));
                index++;
            }
        }


        //Console.WriteLine(politic.Text);

        //var textBox = driver.FindElement(By.Name("my-text"));
        //var submitButton = driver.FindElement(By.TagName("button"));

        //textBox.SendKeys("Selenium");
        //submitButton.Click();

        //var message = driver.FindElement(By.Id("message"));
        //var value = message.Text;
        //Console.WriteLine($"Value: {value}");

        driver.Quit();
}
