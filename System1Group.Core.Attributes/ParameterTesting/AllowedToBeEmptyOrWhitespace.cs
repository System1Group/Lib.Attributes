namespace System1Group.Core.Attributes.ParameterTesting
{
    public class AllowedToBeEmptyOrWhitespace : ExcludeFromAutoParameterTests
    {
        public AllowedToBeEmptyOrWhitespace()
            : base(
                new[] { ExclusionType.DontEmptyTest, ExclusionType.DontWhitespaceTest },
                "Parameter is allowed to be empty or whitespace")
        {
        }
    }
}
