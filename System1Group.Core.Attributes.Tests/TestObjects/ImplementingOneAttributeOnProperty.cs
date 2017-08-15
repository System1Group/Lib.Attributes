namespace System1Group.Core.Attributes.Tests.TestObjects
{
    [ClassOrInterface]
    public class ImplementingOneAttributeOnProperty
    {
        [PropertyOrMethod]
        public string TestProperty { get; private set; }
    }
}
