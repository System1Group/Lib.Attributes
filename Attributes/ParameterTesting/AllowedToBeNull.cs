namespace System1Group.Lib.Attributes.ParameterTesting
{
    public class AllowedToBeNull : ExcludeFromAutoParameterTests
    {
        public AllowedToBeNull()
            : base(ExclusionType.DontNullTest, "Parameter is allowed to be null")
        {
        }
    }
}
