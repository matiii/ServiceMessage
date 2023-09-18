using Confluent.Kafka;

namespace ServiceMessage.Configuration;

public class ServiceMessageOptions
{
    internal ServiceMessageOptions()
    {
    }

    public ProducerConfig ProducerConfig { get; set; }

    public ConsumerConfig ConsumerConfig { get; set; }
}