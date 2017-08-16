namespace System1Group.Lib.Attributes.Tests.TestObjects
{
    [ClassOrInterface]
    public class ImplementingOneAttributeOnProperty
    {
        [PropertyOrMethod]
        public string TestProperty { get; private set; }
    }
}
