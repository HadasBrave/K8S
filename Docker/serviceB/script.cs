namespace ServiceB
{
    using System;
    using System.Threading.Tasks;
    class Program
    {
        static async Task Main(string[] args)
        {
            while(true)
            {
                await Task.Delay(TimeSpan.FromSeconds(10));
                Console.WriteLine("Hello, Microsoft!");
            }
        }
    }
}