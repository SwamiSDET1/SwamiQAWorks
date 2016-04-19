using System.Linq;
using System.Configuration;

namespace SwamiQAWorks.Config
{
    public class ConfigHelper
    {
       private static readonly TestConfiguration TestConfiguration;

        static ConfigHelper()
        {
            TestConfiguration = (TestConfiguration)(dynamic)ConfigurationManager.GetSection("testConfiguration");

        }

        public static TestEnvironmentConfiguration ActiveTestEnvironmentConfiguration => 
            TestConfiguration.TestEnvironmentConfigurations.Single(
                tec => tec.Name == TestConfiguration.ActiveTestEnvironment);
                  
        public static dynamic TestOptions => TestConfiguration.TestOptions;       
    }
}
