namespace System1Group.Core.Attributes.ParameterTesting
{
    public class AllowedToBeEmpty : ExcludeFromAutoParameterTests
    {
        public AllowedToBeEmpty()
            : base(ExclusionType.DontEmptyTest, "Parameter is allowed to be empty")
        {
        }
    }
}
