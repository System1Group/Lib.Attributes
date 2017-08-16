namespace System1Group.Lib.Attributes.ParameterTesting
{
    public class AllowedToBeWhitespace : ExcludeFromAutoParameterTests
    {
        public AllowedToBeWhitespace()
            : base(ExclusionType.DontWhitespaceTest, "Parameter is allowed to be whitespace")
        {
        }
    }
}
