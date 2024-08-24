using OpenQA.Selenium;

namespace RiaParse;

internal static class ElementPath
{
    public static By categoriesOfNews = By.XPath("//div[@class='cell cell-extension']//div[@class='the-in-carousel__stage']//div[@class='cell-extension__item m-with-title']");
    public static By politicCategory = By.XPath("//div[@class='cell cell-extension']//div[@class='the-in-carousel__stage']//div[@class='cell-extension__item m-with-title'][position()=1]");
    public static By itemInCategory = By.XPath("//div[@class='list list-tags']//div[@class='list-item']");
    public static By hyperlinkItemCategoryImage = By.XPath("//div[@class='list list-tags']//div[@class='list-item']//div[@class='list-item__content']//a[1]//picture//source[@media='(min-width: 1160px)']");
    public static By hyperlinkItemCategory = By.XPath("//div[@class='list list-tags']//div[@class='list-item']//div[@class='list-item__content']//a[2]");
}
