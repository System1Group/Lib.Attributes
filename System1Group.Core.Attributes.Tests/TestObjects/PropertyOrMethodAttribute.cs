namespace System1Group.Core.Attributes.Tests.TestObjects
{
    using System;

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class PropertyOrMethodAttribute : Attribute
    {
    }
}