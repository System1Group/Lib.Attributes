namespace System1Group.Core.Attributes.Tests.TestObjects
{
    [ClassOrInterface]
    public class ImplementingTwoAttributesOnProperty
    {
        [PropertyOrMethod]
        public string TestProperty { get; private set; }

        [PropertyOrMethod]
        public string AnotherTestProperty { get; private set; }
    }
}
