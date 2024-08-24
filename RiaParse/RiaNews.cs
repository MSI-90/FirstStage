using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace RiaParse;

public class RiaNews
{
    Config Config { get; set; }
    IWebDriver driver;
    public int CountOfNews { get; set; }
    public RiaNews() 
    {
        Config = new Config();
        driver = new Config().Driver();
    }
    public (IEnumerable<ShortInfoCategory> shortInfoType, IEnumerable<string> shortInfoAsText) GetPoliticsShortNews()
    {
        List<ShortInfoCategory> shortInfoCategories = new List<ShortInfoCategory>();
        List<string> shortInfoText= new List<string>();

        ReadOnlyCollection<IWebElement?> pictureFromCategoryHyperlink;
        ReadOnlyCollection<IWebElement?> titleItemsFromCategoryHyperlink;

        try
        {
            driver.FindElement(ElementPath.politicCategory).Click();
            pictureFromCategoryHyperlink = driver.FindElements(ElementPath.hyperlinkItemCategoryImage);
            titleItemsFromCategoryHyperlink = driver.FindElements(ElementPath.hyperlinkItemCategory);
        }catch (Exception ex)
        {
            throw;
        }
        
        if (titleItemsFromCategoryHyperlink.Any())
        {
            var index = 1;
            foreach (var item in titleItemsFromCategoryHyperlink)
            {
                shortInfoCategories.Add(new ShortInfoCategory
                {
                    Link = item?.GetAttribute("href"),
                    Title = item?.Text,
                    Picture = pictureFromCategoryHyperlink?[index - 1]?.GetAttribute("srcset")
                });
                shortInfoText.Add(
                    $"{item?.GetAttribute("href")}\n{item?.Text}\n{pictureFromCategoryHyperlink?[index - 1]?.GetAttribute("srcset")}\n"
                );
                index++;
            }
        }
        driver.Quit();
        CountOfNews = shortInfoCategories.Count();

        return (shortInfoType: shortInfoCategories, shortInfoAsText: shortInfoText);
    }
}
