﻿namespace System1Group.Lib.Attributes.ParameterTesting
{
    public class AllowedToBeNullOrEmpty : ExcludeFromAutoParameterTests
    {
        public AllowedToBeNullOrEmpty()
            : base(
                new[] { ExclusionType.DontNullTest, ExclusionType.DontEmptyTest },
                "Parameter is allowed to be null or empty")
        {
        }
    }
}
