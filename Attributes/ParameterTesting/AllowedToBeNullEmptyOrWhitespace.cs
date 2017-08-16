﻿namespace System1Group.Lib.Attributes.ParameterTesting
{
    public class AllowedToBeNullEmptyOrWhitespace : ExcludeFromAutoParameterTests
    {
        public AllowedToBeNullEmptyOrWhitespace()
            : base(
                new[] { ExclusionType.DontNullTest, ExclusionType.DontEmptyTest, ExclusionType.DontWhitespaceTest },
                "Parameter is allowed to be null, empty or whitespace")
        {
        }
    }
}
