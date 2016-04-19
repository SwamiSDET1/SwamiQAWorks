namespace SwamiQAWorks.Config
{
    public class TestEnvironmentConfiguration
    {
        public TestEnvironment Name { get; set; }
        public string BaseUrl { get; set; }
    }

    public enum TestEnvironment
    {
        staging,
        local
    }
}
