using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UOM.Tests.Acceptance.Hosting;

namespace UOM.Tests.Acceptance.Hooks
{
    [Binding]
    public class HostingHook
    {
        static IISExpressHost host;
        [BeforeTestRun]
        public static void BeforeTestSuiteRun()
        {
            //TODO: do not hard code this, nooooooooooooooooooo
            var projectPath = @"C:\Courses\Jame-GodOfWar\Session 15\GodOfWar\Code\ServiceHost";
            host = new IISExpressHost(projectPath, 20070);
            host.Start();
        }

        [AfterTestRun]
        public static void AfterTestSuiteRun()
        {
            host.Stop();
        }
    }
}
