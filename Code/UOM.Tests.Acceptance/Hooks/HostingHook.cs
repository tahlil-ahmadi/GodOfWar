using System;
using System.Collections.Generic;
using System.IO;
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
            var projectPath = Path.GetFullPath(@"..\..\..\ServiceHost");
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
