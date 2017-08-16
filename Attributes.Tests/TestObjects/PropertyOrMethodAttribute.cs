namespace System1Group.Lib.Attributes.Tests.TestObjects
{
    using System;

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class PropertyOrMethodAttribute : Attribute
    {
    }
}