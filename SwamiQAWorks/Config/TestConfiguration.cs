using System;
using System.Collections.Generic;

namespace SwamiQAWorks.Config
{
    public class TestConfiguration
    {
        private TestEnvironment _activeTestEnvironment;

        public TestEnvironment ActiveTestEnvironment
        {
            get { return _activeTestEnvironment; }
            set
            {
                _activeTestEnvironment = (TestEnvironment)Enum.Parse(typeof(TestEnvironment), value.ToString());
                Console.WriteLine("Test environment set to {0}", _activeTestEnvironment);
            }
        }

        public TestOptions TestOptions { get; set; }

        public List<TestEnvironmentConfiguration> TestEnvironmentConfigurations { get; set; }
    }
}

