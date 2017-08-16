namespace System1Group.Lib.Attributes.Tests.TestObjects
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
