using Microsoft.Extensions.DependencyInjection;
using ServiceMessage.Abstraction.Configuration;
using ServiceMessage.Abstraction.Consumer;
using ServiceMessage.Configuration;
using ServiceMessage.Consumer;

namespace ServiceMessage;

public static class ServiceMessageExtensions
{
    public static void AddServiceMessage<TServiceMessageModuleDefinition>(
        this IServiceCollection serviceCollection,
        Action<ServiceMessageOptions>? options = null)
        where TServiceMessageModuleDefinition : class, IServiceMessageModuleDefinition, IServiceMessageProcessor
    {
        serviceCollection.AddSingleton<IServiceMessageModuleDefinition, TServiceMessageModuleDefinition>();
        serviceCollection.AddSingleton<IServiceMessageProcessor, TServiceMessageModuleDefinition>();
        serviceCollection.AddSingleton<IServiceMessageTopicDefinition, ServiceMessageTopicDefinition>();

        serviceCollection.AddHostedService<ServiceMessageConsumer>();

        var smOptions = new ServiceMessageOptions();
        options?.Invoke(smOptions);

        serviceCollection.AddSingleton(smOptions);
    }
}