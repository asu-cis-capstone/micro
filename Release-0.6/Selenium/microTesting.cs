using NUnit.Framework;
using NUnit.Core;

namespace SeleniumTests
{
    public class MicroTesting
    {
        [Suite] public static TestSuite Suite
        {
            get
            {
                TestSuite suite = new TestSuite("MicroTesting");
                suite.Add(new SearchBar());
                suite.Add(new Microwiki());
                suite.Add(new Login());
                suite.Add(new Editing());
                suite.Add(new BackToMainPage());
                return suite;
            }
        }
    }
}
