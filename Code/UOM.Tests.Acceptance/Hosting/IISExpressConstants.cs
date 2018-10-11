using System;
using System.IO;

namespace UOM.Specs.Hosting
{
    public static class IISExpressConstants
    {
        public readonly static string path = Path.GetPathRoot(Environment.SystemDirectory);
        //path install windows
        public readonly static string IISExpressX86Path = path.Replace(@"\", "") +  @"\Program Files (x86)\IIS Express\iisexpress.exe"; 
        public const string IISExpressPath = @"C:\Program Files\IIS Express\iisexpress.exe";
    }
}
