internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BusinessModuleProxy proxy = new BusinessModuleProxy();
        proxy.Method();
    }
}