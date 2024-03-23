namespace Principle_Segregate
{
    internal class Amazon : ICloudHostingProvider, ICloudStoregeProvider, ICDN
    {
        public void CreateServer(string region)
        {
            Console.WriteLine("Server saqlandi");
        }

        public void GetCDNAdress()
        {
            Console.WriteLine("Adress belgilandi");
        }

        public void GetFile(string name)
        {
            Console.WriteLine("Amazon: fayl olindi");
        }

        public void ListServers(string region)
        {
            Console.WriteLine("Serevlar ro`yxati");
        }

        public void StoreFile(string name)
        {
            Console.WriteLine("Amazon: faly belgilandi");
        }
    }
}
