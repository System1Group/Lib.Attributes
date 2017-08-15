namespace System1Group.Core.Attributes.ParameterTesting
{
    public class CurrentlyUnSupportedByAutoParameterTesting : ExcludeFromAutoParameterTests
    {
        public CurrentlyUnSupportedByAutoParameterTesting(string reasonForExclusion)
            : base(ExclusionType.DontTest, reasonForExclusion)
        {
        }
    }
}
