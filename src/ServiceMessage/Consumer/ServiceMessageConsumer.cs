using Microsoft.Extensions.Hosting;
using ServiceMessage.Abstraction.Configuration;
using ServiceMessage.Configuration;

namespace ServiceMessage.Consumer;

internal class ServiceMessageConsumer : BackgroundService
{
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
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        throw new NotImplementedException();
    }
}