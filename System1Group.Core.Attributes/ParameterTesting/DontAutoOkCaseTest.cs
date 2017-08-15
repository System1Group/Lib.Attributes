namespace System1Group.Core.Attributes.ParameterTesting
{
    using System;

    [AttributeUsage(AttributeTargets.Constructor)] // allowed and only relevant on constructors
    public class DontAutoOkCaseTest : ExcludeFromAutoParameterTests
    {
        public DontAutoOkCaseTest()
            : base(ExclusionType.DontOkTest, "Constructor shouldn't be included in automated ok case tests, it will be ok case tested manually")
        {
        }

        public DontAutoOkCaseTest(string reasonForExclusion)
            : base(ExclusionType.DontOkTest, reasonForExclusion)
        {
        }
    }
}
