namespace System1Group.Lib.Attributes.ParameterGeneration
{
    using System;
    using CoreUtils;

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Class)]
    public class AllowCreationWhenAutomating : Attribute
    {
        private string allowReason;

        public AllowCreationWhenAutomating(string reasonForAllowing)
        {
            this.AllowReason = ReturnParameter.OrThrowIfNullEmptyOrWhitespace(reasonForAllowing, "reasonForExclusion");
        }

        public string AllowReason
        {
            get
            {
                return this.allowReason;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "When allowing automated creation of a parameter a valid reason that explains why it does not need decoupling (e.g. it's just a custom or system DO) must be given!");
                }

                this.allowReason = value;
            }
        }
    }
}
