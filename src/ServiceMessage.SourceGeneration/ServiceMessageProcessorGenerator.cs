using Microsoft.CodeAnalysis;

namespace ServiceMessage.SourceGeneration;

[Generator(LanguageNames.CSharp)]
internal sealed class ServiceMessageProcessorGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        throw new NotImplementedException();
    }
}