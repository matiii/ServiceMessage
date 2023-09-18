namespace ServiceMessage.Abstraction.Consumer;

public interface IServiceMessageProcessor
{
    Task ProcessMessage(Type messageType, byte[] messageData, IServiceProvider scopedServiceProvider);
}