namespace System1Group.Core.Attributes.ParameterTesting
{
    public class AllowedToBeNull : ExcludeFromAutoParameterTests
    {
        public AllowedToBeNull()
            : base(ExclusionType.DontNullTest, "Parameter is allowed to be null")
        {
        }
    }
}
