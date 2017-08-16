namespace System1Group.Lib.Attributes.ParameterTesting
{
    public class AllowedToBeEmpty : ExcludeFromAutoParameterTests
    {
        public AllowedToBeEmpty()
            : base(ExclusionType.DontEmptyTest, "Parameter is allowed to be empty")
        {
        }
    }
}
