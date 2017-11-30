[![Build status](https://ci.appveyor.com/api/projects/status/kiim5op48rimx51g/branch/master?svg=true)](https://ci.appveyor.com/project/System1Group/lib-attributes/branch/master)

# Lib.Attributes
Contains shared attributes used by other code

## Object Building

### `UseForObjectBuilding`
Marks a constructor as the default for automatic object building
```csharp
class SomeClass
{
    public SomeClass(string dependency)
    {
        // ctor logic
    }

    [UseForObjectBuilding]
    public SomeClass(string dependency, int anotherDependency)
    {
        // ctor logic
    }
}
```

## Parameter Testing
These attributes give the automatic parameter tester hints about how to build and test a class

### `AllowCreationWhenAutomating`, `DoesNotIntroduceCoupling`, `IsPOCO`
The parameter tester's default behaviour is to fail a test if it detects coupling between classes. 
This behaviour can be changed with the `AllowCreationWhenAutomating` attribute, or its subclasses.

```csharp
class ClassA
{
}

class ClassB
{
    // Param tester will fail to generate tests because it detects coupling
    public void MethodWithConcreteDependencyA(ClassA dependency)
    {
        // Some logic
    }
    
    // Param tester will attempt to build instance of ClassA
    public void MethodWithConcreteDependencyB([AllowCreationWhenAutomating("Have to provide a reason")]ClassA dependency)
    {
        // Some logic
    }
    
    public void MethodWithConcreteDependencyC([DoesNotIntroduceCoupling]ClassA dep1, [IsPOCO]ClassA dep2)
    {
        // Some logic
    }
}
```

### `UseNullWhenAutomating`
As with the attributes above, except instead of trying to build the dependent class, the parameter tester passes `null`.

### `AllowedToBe...`
If a parameter is allowed to be `null`, or, in the case of a `string`, empty or whitespace, then it needs to be marked with one of the following:

* `[AllowedToBeNull]`
* `[AllowedToBeEmpty]`
* `[AllowedToBeEmptyOrWhitespace]`
* `[AllowedToBeNullEmptyOrWhitespace]`
* `[AllowedToBeNullOrEmpty]`
* `[AllowedToBeNullOrWhitespace]`
* `[AllowedToBeWhitespace]`

### `ExcludeFromAutoParameterTests`

Methods, constructors or entire classes can be excluded from testing with `[ExcludeFromAutoParameterTests]`

## Windsor Tester

### DoNotIncludeInWindsorTest

Marks a parameter or constructor as not to be tested
