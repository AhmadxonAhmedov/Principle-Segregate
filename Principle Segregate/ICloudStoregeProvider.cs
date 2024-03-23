namespace Principle_Segregate
{
    internal interface ICloudStoregeProvider 
    {
        void StoreFile(string name);
        void GetFile(string name);
    }
}
