using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using SwamiQAWorks.Config;

namespace SwamiQAWorks.PageObjects
{
    public class ContactUsPage:BasePage
    {
        [FindsBy(How = How.Id, Using = "ctl00_MainContent_NameBox")]
        private IWebElement _nameInput;

        [FindsBy(How = How.Id, Using = "ContactMessageBox")]
        private IWebElement _messagBoxInput;

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_EmailBox")]
        private IWebElement _emailInput;

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_SendButton")]
        private IWebElement _sendButton;

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_rfvEmailAddress")]
        private IWebElement _emailFieldValidationMessage;

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_rfvName")]
        private IWebElement _nameFieldValidationMessage;

        [FindsBy(How = How.Id, Using = "ctl00_MainContent_rfvMessage")]
        private IWebElement _messagefieldValidation;


        public ContactUsPage(IWebDriver driver):base(driver)
        {
        }

        public string EmailFieldValidation => _emailFieldValidationMessage.Text;
        public string NameFieldValidation => _nameFieldValidationMessage.Text;
        public string MessageFieldValidation => _messagefieldValidation.Text;

        public override void GoTo()
        {
            Driver.Url = ConfigHelper.ActiveTestEnvironmentConfiguration.BaseUrl + "contact.aspx";
        }

        public void SendAMessage(string name, string emailAddress, string message)
        {
            WaitFor10Seconds.Until(d => _nameInput.Displayed);
            _messagBoxInput.Click();
            TypeMessage(message);
            _nameInput.Click();
            _nameInput.SendKeys(name);
            _emailInput.Click();
            _emailInput.SendKeys(emailAddress);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", _sendButton);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", _emailInput);
            _sendButton.Click();
        }

        public void TypeMessage(string message)
        {
            new Actions(Driver)
                .MoveToElement(_messagBoxInput)
                .SendKeys(message)
                .Perform();
        }
   }
}
