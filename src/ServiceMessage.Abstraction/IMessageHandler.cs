namespace ServiceMessage.Abstraction;

public interface IMessageHandler<in TMessage>
{
    ValueTask Handle(TMessage message);
}