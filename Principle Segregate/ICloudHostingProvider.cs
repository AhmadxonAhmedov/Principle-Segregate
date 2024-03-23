namespace Principle_Segregate
{
    internal interface ICloudHostingProvider
    {
        void CreateServer(string region);
        void ListServers(string region);
    }
}
