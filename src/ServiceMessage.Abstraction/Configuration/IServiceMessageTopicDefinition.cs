namespace ServiceMessage.Abstraction.Configuration;

public interface IServiceMessageTopicDefinition
{
    void DefineTopic<TMessage>();

    void DefineTopic<TMessage>(string topicName);
}