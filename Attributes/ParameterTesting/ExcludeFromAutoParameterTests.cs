namespace System1Group.Lib.Attributes.ParameterTesting
{
    using System;
    using System.Collections.Generic;
    using CoreUtils;

    [AttributeUsage(
        AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method
        | AttributeTargets.Parameter | AttributeTargets.Property)]
    public class ExcludeFromAutoParameterTests : Attribute
    {
        private string exclusionReason;

        public ExcludeFromAutoParameterTests(IEnumerable<ExclusionType> exclusionTypes, string reasonForExclusion)
            : this()
        {
            this.ExclusionTypes.AddRange(exclusionTypes);
            this.ExclusionReason = reasonForExclusion;
        }

        public ExcludeFromAutoParameterTests(ExclusionType exclusionType, string reasonForExclusion) : this()
        {
            this.ExclusionTypes.Add(exclusionType);
            this.ExclusionReason = reasonForExclusion;
        }

        public ExcludeFromAutoParameterTests(string reasonForExclusion)
            : this(ExclusionType.DontTest, reasonForExclusion)
        {
        }

        private ExcludeFromAutoParameterTests()
        {
            this.ExclusionTypes = new List<ExclusionType>();
        }

        public List<ExclusionType> ExclusionTypes { get; private set; }

        public string ExclusionReason
        {
            get
            {
                return this.exclusionReason;
            }

            private set
            {
                this.exclusionReason = ReturnParameter.OrThrowIfNullEmptyOrWhitespace(value, "value");
            }
        }
    }
}
