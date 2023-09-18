namespace ServiceMessage.Abstraction;

public interface IServiceMessage
{
    Task Dispatch<TMessage>(TMessage message);

    void Publish<TMessage>(TMessage message);
}