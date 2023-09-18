using ServiceMessage.Abstraction;

namespace ServiceMessage;

public class ServiceMessage : IServiceMessage
{
    public Task Dispatch<TMessage>(TMessage message)
    {
        throw new NotImplementedException();
    }

    public void Publish<TMessage>(TMessage message)
    {
        throw new NotImplementedException();
    }
}