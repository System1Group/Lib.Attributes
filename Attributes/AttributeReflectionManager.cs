namespace System1Group.Lib.Attributes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System1Group.Lib.Attributes.ParameterGeneration;
    using System1Group.Lib.Attributes.ParameterTesting;

    public static class AttributeReflectionManager
    {
        public static IEnumerable<PropertyInfo> GetPropertiesImplementing<TAttribute>([AllowedToBeNull, DoesNotIntroduceCoupling] Type type) where TAttribute : Attribute
        {
            return type == null ? new List<PropertyInfo>() : type.GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(TAttribute)));
        }

        public static IEnumerable<MethodInfo> GetMethodsImplementing<TAttribute>([AllowedToBeNull, DoesNotIntroduceCoupling] Type type) where TAttribute : Attribute
        {
            return type == null ? new List<MethodInfo>() : type.GetMethods().Where(meth => Attribute.IsDefined(meth, typeof(TAttribute)));
        }

        public static IEnumerable<Type> GetClassesImplementing<TAttribute>([AllowedToBeNull] IEnumerable<Type> types) where TAttribute : Attribute
        {
            return types == null ? new List<Type>() : types.Where(type => type.IsClass && Attribute.IsDefined(type, typeof(TAttribute)));
        }
    }
}
