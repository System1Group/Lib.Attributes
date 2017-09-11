namespace System1Group.Lib.Attributes.WindsorTesting
{
    using System;
    using CoreUtils;

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Constructor)]
    public class DoNotIncludeInWindsorTest : Attribute
    {
        private string reason;

        public DoNotIncludeInWindsorTest()
            : this("No reason given")
        {
        }

        public DoNotIncludeInWindsorTest(string reason)
        {
            this.reason = ReturnParameter.OrThrowIfNullEmptyOrWhitespace(reason, nameof(reason));
        }

        public string Reason
        {
            get
            {
                return this.reason;
            }

            set
            {
                Throw.IfNull(value, nameof(value));
                this.reason = value;
            }
        }
    }
}
