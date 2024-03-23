namespace Principle_Segregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amazon amazon = new Amazon();
            DigitalOcean digitalOcean = new DigitalOcean();
            amazon.CreateServer("Uzbekistan");
            amazon.ListServers("List");
            amazon.GetCDNAdress();
            amazon.StoreFile("Fayl");
            amazon.GetFile("Path name");
            digitalOcean.StoreFile("Fayl");
            digitalOcean.GetFile("Path name");

            Console.ReadLine(); 
            
        }
    }
}
