namespace ServiceMessage.SourceGeneration;

internal static class SourceGenerationDefaults
{
    public static readonly string GeneratedCodeAttribute =
        $@"[global::System.CodeDom.Compiler.GeneratedCodeAttribute(""{typeof(ServiceMessageGenerator).Assembly.GetName().Name}"", ""{typeof(ServiceMessageGenerator).Assembly.GetName().Version}"")]";
}