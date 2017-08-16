namespace System1Group.Lib.Attributes.Tests.TestObjects
{
    [ClassOrInterface]
    public class ImplementingTwoAttributesOnMethod
    {
        [PropertyOrMethod]
        public string TestMethod()
        {
            return string.Empty;
        }

        [PropertyOrMethod]
        public string AnotherTestMethod()
        {
            return string.Empty;
        }
    }
}
