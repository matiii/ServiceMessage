using Microsoft.CodeAnalysis;

namespace ServiceMessage.SourceGeneration;

[Generator(LanguageNames.CSharp)]
internal sealed class ServiceMessageGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        throw new NotImplementedException();
    }
}