using FluentAssertions;
using SwamiQAWorks.PageObjects;
using SwamiQAWorks.Config;
using TechTalk.SpecFlow;
using System;

namespace SwamiQAWorks.Steps
{
    [Binding]
    public sealed class ContactUsSteps
    {
        private ContactUsPage _contactUsPage;

        public ContactUsSteps()
        {
            _contactUsPage = new ContactUsPage(Context.Driver);
        }

        [Given(@"I am on the Contact Us Page")]
        public void GivenIAmOnTheContactUsPage()
        {
            _contactUsPage.GoTo();
        }

        [When(@"I send a message ""(.*)"" as ""(.*)""and with the email address ""(.*)""")]
        public void WhenISendAMessageAsAndWithEmailAddress(string message, string name, string emailAddress)
        {
            _contactUsPage.SendAMessage(name, emailAddress, message);
        }


        [When(@"as ""(.*)"" with""(.*)"" I Attempt to send ""(.*)"" without filling in all the required fields")]
        public void WhenAsWithIAttemptToSendWithoutFillingInAllTheRequiredFields(string name, string emailAddress, string message)
        {
            _contactUsPage.SendAMessage(name, emailAddress, message);
        }

         [Then(@"the validation message should be ""(.*)"",""(.*)"" and ""(.*)""")]
        public void ThenTheValidationMessageShouldBeAnd(string nameValidationmessage, string emailValidationMessage, string messageValidation)
        {
            _contactUsPage.EmailFieldValidation.Should().Be(emailValidationMessage);
            _contactUsPage.MessageFieldValidation.Should().Be(messageValidation);
            _contactUsPage.NameFieldValidation.Should().Be(nameValidationmessage);
        }

        [Then(@"the message should be sent successfully")]
        public void ThenTheMessageShouldBeSentSuccessfully()
        {
            var expectedTiltle = "QAWorks";
            var expectedUri = ConfigHelper.ActiveTestEnvironmentConfiguration.BaseUrl + "contact.aspx";

            Context.Driver.Title.Should().Be(expectedTiltle);
            new Uri(Context.Driver.Url).Should().Be(expectedUri);

            _contactUsPage.EmailFieldValidation.Should().BeNullOrEmpty();
            _contactUsPage.MessageFieldValidation.Should().BeNullOrEmpty();
            _contactUsPage.NameFieldValidation.Should().BeNullOrEmpty();

        }
    }
}
