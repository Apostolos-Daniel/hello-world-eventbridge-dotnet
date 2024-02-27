namespace hello_world_eventbridge_dotnet;

using System.Text.Json;
using Amazon.EventBridge;
using Amazon.EventBridge.Model;

class Program
{

    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var eventBridgeClient = new AmazonEventBridgeClient();

        Console.WriteLine($"Hello Amazon EventBridge! Following are some of your EventBuses:");
        Console.WriteLine();

        Console.WriteLine("Current event rules:");

         var eventDetail = new
        {
            Message = "Hello world",
            UtcTime = DateTime.UtcNow.ToString("g")
        };

        Console.WriteLine(new string('-', 80));
        
        Console.ReadLine();
    }
}
