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

        // You can use await and any of the async methods to get a response.
        // Let's get the first five event buses.
        var response = await eventBridgeClient.ListEventBusesAsync(
            new ListEventBusesRequest()
            {
                Limit = 5
            });

        foreach (var eventBus in response.EventBuses)
        {
            Console.WriteLine($"\tEventBus: {eventBus.Name}");
            Console.WriteLine($"\tArn: {eventBus.Arn}");
            Console.WriteLine($"\tPolicy: {eventBus.Policy}");
            Console.WriteLine();
        }

        Console.WriteLine(new string('-', 80));
        var enabledWhiteLabels = new List<string> { "whiteLabel1", "whiteLabel2" };

         var eventDetail = new
        {
            Message = "Hello world",
            UtcTime = DateTime.UtcNow.ToString("g"),
            EnabledWhiteLabels = enabledWhiteLabels
        };

        var putEventsResponse = await eventBridgeClient.PutEventsAsync(
            new PutEventsRequest()
            {
                Entries = new List<PutEventsRequestEntry>()
                {
                    new PutEventsRequestEntry()
                    {
                        Source = "dotnetHelloWorldApp",// where the event is coming from
                        Detail = JsonSerializer.Serialize(eventDetail),// the actual data
                        DetailType = "HelloWorld",// the event name
                        EventBusName = "tamas-loyalty-LoyaltyBus"
                    }
                },
            });

        Console.WriteLine("PutEventsResponse:", putEventsResponse);

        Console.WriteLine(new string('-', 80));
    }
}
