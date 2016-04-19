using SwamiQAWorks.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SwamiQAWorks
{
    public class BrowserBuilder
    {
        public IWebDriver BuildFromTestOptions(dynamic options)
        {
            IWebDriver driver = null;

            switch ((BrowserEnum)options.Browser)
            {
                case BrowserEnum.Chrome:
                    driver = new ChromeDriver(PathToTheDriver());
                    break;
                case BrowserEnum.FireFox:
                    driver = new FirefoxDriver();
                    break;
            }

            return driver;
        }


        public string PathToTheDriver()
        {
           return @"C:\Users\swaminathan\Documents\Visual Studio 2015\Projects\SwamiQAWorks\SwamiQAWorks\Resources\ChromeDriver\";    
        }
    }
}
