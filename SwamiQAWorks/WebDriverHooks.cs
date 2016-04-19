using SwamiQAWorks.Config;
using System;
using TechTalk.SpecFlow;

namespace SwamiQAWorks
{
    [Binding]
    public sealed class WebDriverHooks
    {
        [BeforeTestRun]
        public static void CreateDriver()
        {
            Context.Driver = new BrowserBuilder().BuildFromTestOptions(ConfigHelper.TestOptions);
            Context.Driver.Manage().Window.Maximize();
            Context.Driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(60));
            Context.Driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(60));
        }

        [AfterTestRun]
        public static void ShutDownDriver()
        {
            Context.Driver.Close();
            Context.Driver.Dispose();
        }
    }
}
