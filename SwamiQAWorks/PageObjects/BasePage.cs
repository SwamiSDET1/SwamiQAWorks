using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SwamiQAWorks.Config;
using System;

namespace SwamiQAWorks.PageObjects
{
    public abstract class BasePage
    {
        protected IWebDriver Driver { get; private set; }
        protected string BaseUrl { get; private set; }
        protected WebDriverWait WaitFor10Seconds;

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
            BaseUrl = ConfigHelper.ActiveTestEnvironmentConfiguration.BaseUrl;
            WaitFor10Seconds = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        public virtual void GoTo()
        {
            throw new NotImplementedException();
        }
    }
}
