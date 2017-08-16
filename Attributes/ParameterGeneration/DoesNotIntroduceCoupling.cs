namespace System1Group.Lib.Attributes.ParameterGeneration
{
    public class DoesNotIntroduceCoupling : AllowCreationWhenAutomating
    {
        public DoesNotIntroduceCoupling()
            : base("This parameter is a type that does not introduce coupling such as a custom or system Domain Object")
        {
        }

        public DoesNotIntroduceCoupling(string reason)
            : base(reason)
        {
        }
    }
}
