namespace System1Group.Core.Attributes.Tests.AttributeReflectionManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using System1Group.Core.Attributes;
    using System1Group.Core.Attributes.Tests.TestObjects;

    [TestFixture]
    public class AttributeReflectionManager_Tests
    {
        [Test]
        public void AttributeReflectionManager_GetPropertiesImplementing_Null()
        {
            Assert.IsEmpty(AttributeReflectionManager.GetPropertiesImplementing<Attribute>(null));
        }

        [Test]
        public void AttributeReflectionManager_GetPropertiesImplementing_NonQualifyingObject()
        {
            Assert.IsEmpty(AttributeReflectionManager.GetPropertiesImplementing<Attribute>(typeof(object)));
        }

        [Test]
        public void AttributeReflectionManager_GetPropertiesImplementing_QualifyingObject_1Match()
        {
            var matching = AttributeReflectionManager.GetPropertiesImplementing<Attribute>(typeof(ImplementingOneAttributeOnProperty)).ToList();
            Assert.That(matching.Count, Is.EqualTo(1));
        }

        [Test]
        public void AttributeReflectionManager_GetPropertiesImplementing_QualifyingObject_2Matches()
        {
            var matching = AttributeReflectionManager.GetPropertiesImplementing<Attribute>(typeof(ImplementingTwoAttributesOnProperty)).ToList();
            Assert.That(matching.Count, Is.EqualTo(2));
        }

        [Test]
        public void AttributeReflectionManager_GetMethodsImplementing_Null()
        {
            Assert.That(AttributeReflectionManager.GetMethodsImplementing<Attribute>(null), Is.Empty);
        }

        [Test]
        public void AttributeReflectionManager_GetMethodsImplementing_NonQualifyingObject()
        {
            Assert.That(AttributeReflectionManager.GetMethodsImplementing<PropertyOrMethodAttribute>(typeof(object)), Is.Empty);
        }

        [Test]
        public void AttributeReflectionManager_GetMethodsImplementing_QualifyingObject_1Match()
        {
            var matching = AttributeReflectionManager.GetMethodsImplementing<PropertyOrMethodAttribute>(typeof(ImplementingOneAttributeOnMethod)).ToList();
            Assert.That(matching.Count, Is.EqualTo(1));
        }

        [Test]
        public void AttributeReflectionManager_GetMethodsImplementing_QualifyingObject_2Matches()
        {
            var matching = AttributeReflectionManager.GetMethodsImplementing<PropertyOrMethodAttribute>(typeof(ImplementingTwoAttributesOnMethod)).ToList();
            Assert.That(matching.Count, Is.EqualTo(2));
        }

        [Test]
        public void AttributeReflectionManager_GetClassesImplementing_Null()
        {
            Assert.That(AttributeReflectionManager.GetClassesImplementing<Attribute>(null), Is.Empty);
        }

        [Test]
        public void AttributeReflectionManager_GetClassesImplementing_NonQualifyingObject()
        {
            Assert.That(AttributeReflectionManager.GetClassesImplementing<PropertyOrMethodAttribute>(new List<Type> { typeof(object), typeof(IImplementAttribute) }), Is.Empty);
        }

        [Test]
        public void AttributeReflectionManager_GetClassesImplementing_QualifyingObject_1Match()
        {
            var matching = AttributeReflectionManager.GetClassesImplementing<Attribute>(new List<Type> { typeof(ImplementingOneAttributeOnMethod), typeof(IImplementAttribute) }).ToList();
            Assert.That(matching.Count, Is.EqualTo(1));
        }

        [Test]
        public void AttributeReflectionManager_GetClassesImplementing_QualifyingObject_2Matches()
        {
            var matching = AttributeReflectionManager.GetClassesImplementing<Attribute>(new List<Type> { typeof(ImplementingTwoAttributesOnProperty), typeof(ImplementingOneAttributeOnMethod), typeof(IImplementAttribute) }).ToList();
            Assert.That(matching.Count, Is.EqualTo(2));
        }

        [Test]
        public void AttributeReflectionManager_GetClassesImplementing_QualifyingObject_ByInterface()
        {
            // This is not desired behaviour, but actual implementation is for a later refactor!
            Assert.That(AttributeReflectionManager.GetClassesImplementing<PropertyOrMethodAttribute>(new List<Type> { typeof(ImplementsAttributeOnInterface), typeof(IImplementAttribute) }), Is.Empty);
        }
    }
}
