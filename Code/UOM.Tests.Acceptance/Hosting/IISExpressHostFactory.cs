namespace UOM.Specs.Hosting
{
    public class IISExpressHostFactory
    {
        public static IISExpressHost Create(string targetProjectFolder, int port,
            string iisExePath = null)
        {
            return new IISExpressHost(targetProjectFolder, port,iisExePath);
        }
    }
}
