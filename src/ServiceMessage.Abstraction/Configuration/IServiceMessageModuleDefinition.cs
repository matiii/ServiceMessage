namespace ServiceMessage.Abstraction.Configuration;

public interface IServiceMessageModuleDefinition
{
    void DefineTopics(IServiceMessageTopicDefinition topicDefinition);
}