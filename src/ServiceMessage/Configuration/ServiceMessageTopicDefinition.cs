using ServiceMessage.Abstraction.Configuration;

namespace ServiceMessage.Configuration;

public class ServiceMessageTopicDefinition : IServiceMessageTopicDefinition
{
    public void DefineTopic<TMessage>()
    {
        throw new NotImplementedException();
    }

    public void DefineTopic<TMessage>(string topicName)
    {
        throw new NotImplementedException();
    }
}