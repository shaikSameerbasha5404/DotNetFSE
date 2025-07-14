using Confluent.Kafka;
using System;

class ChatProducer
{
    public static async Task Main(string[] args)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        Console.WriteLine("Enter messages to send to Kafka ('exit' to quit):");

        while (true)
        {
            var msg = Console.ReadLine();
            if (msg.ToLower() == "exit") break;

            await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = msg });
            Console.WriteLine("Sent: " + msg);
        }
    }
}
