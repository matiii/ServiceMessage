using Confluent.Kafka;
using Microsoft.Extensions.Hosting;
using ServiceMessage.Abstraction.Configuration;
using ServiceMessage.Configuration;

namespace ServiceMessage.Consumer;

internal class ServiceMessageConsumer : BackgroundService
{
    private readonly IConsumer<byte[], byte[]> _consumer;
    private readonly IServiceProvider _serviceProvider;
    private readonly IServiceMessageTopicDefinition _topicDefinition;
    private readonly IServiceMessageModuleDefinition _moduleDefinition;
    private readonly ServiceMessageOptions _options;

    public ServiceMessageConsumer(
        IServiceProvider serviceProvider,
        IServiceMessageTopicDefinition topicDefinition,
        IServiceMessageModuleDefinition moduleDefinition,
        ServiceMessageOptions options)
    {
        _serviceProvider = serviceProvider;
        _topicDefinition = topicDefinition;
        _moduleDefinition = moduleDefinition;
        _options = options;

        _consumer = new ConsumerBuilder<byte[], byte[]>(_options.ConsumerConfig).Build();
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        throw new NotImplementedException();
    }
}