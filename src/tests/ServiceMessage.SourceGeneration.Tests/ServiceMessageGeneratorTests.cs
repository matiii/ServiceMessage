using VerifyCS = ServiceMessage.SourceGeneration.Tests.Verifiers.CSharpSourceGeneratorVerifier<ServiceMessage.SourceGeneration.ServiceMessageGenerator>;

namespace ServiceMessage.SourceGeneration.Tests;

public class ServiceMessageGeneratorTests
{
    [Fact]
    public async Task Should_Generate_Message_Processor()
    {
        // arrange
        var codeBase = """
""";
        var expectedCode = """
    code will be defined here
""";

        // act
        // assert
        await VerifyCS.VerifyGeneratorAsync(codeBase, ("EqualityComparerAttribute.g.cs", expectedCode));
    }
}