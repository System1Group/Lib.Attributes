namespace System1Group.Core.Attributes.ParameterTesting
{
    public class AllowedToBeNullOrWhitespace : ExcludeFromAutoParameterTests
    {
        public AllowedToBeNullOrWhitespace()
            : base(
                new[] { ExclusionType.DontNullTest, ExclusionType.DontWhitespaceTest },
                "Parameter is allowed to be null or whitespace")
        {
        }
    }
}
