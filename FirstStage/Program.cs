using RiaParse;

namespace FirstStage;

internal class Program
{
    static void Main(string[] args)
    {
        var riaNews = new RiaNews();
        var news = riaNews.GetPoliticsShortNews();
        Console.WriteLine($"\nВсего новостей в категории: {riaNews.CountOfNews}");
        
        foreach (var item in news.shortInfoAsText)
        {
            Console.WriteLine(item);
        }
    }
}
