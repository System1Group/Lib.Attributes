namespace System1Group.Lib.Attributes.ParameterTesting
{
    public class CurrentlyUnSupportedByAutoParameterTesting : ExcludeFromAutoParameterTests
    {
        public CurrentlyUnSupportedByAutoParameterTesting(string reasonForExclusion)
            : base(ExclusionType.DontTest, reasonForExclusion)
        {
        }
    }
}
