namespace hello_world_eventbridge_dotnet;
using Amazon.EventBridge;
using Amazon.EventBridge.Model;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // var eventBridgeClient = new AmazonEventBridgeClient();

        Console.WriteLine($"Hello Amazon EventBridge! Following are some of your EventBuses:");
        Console.WriteLine();

        // You can use await and any of the async methods to get a response.
        // Let's get the first five event buses.
        // var response = eventBridgeClient.ListEventBusesAsync(
        //     new ListEventBusesRequest()
        //     {
        //         Limit = 5
        //     }).Result;

        // foreach (var eventBus in response.EventBuses)
        // {
        //     Console.WriteLine($"\tEventBus: {eventBus.Name}");
        //     Console.WriteLine($"\tArn: {eventBus.Arn}");
        //     Console.WriteLine($"\tPolicy: {eventBus.Policy}");
        //     Console.WriteLine();
        // }
    }
}
