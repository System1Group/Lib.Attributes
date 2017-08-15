namespace System1Group.Core.Attributes.ObjectBuilding
{
    using System;
    using CoreUtils;

    [AttributeUsage(AttributeTargets.Constructor)]
    public class UseForObjectBuilding : Attribute
    {
        private string reason;

        public UseForObjectBuilding() : this("No reason given")
        {
        }

        public UseForObjectBuilding(string reason)
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
