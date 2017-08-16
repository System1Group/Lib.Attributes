namespace System1Group.Lib.Attributes.ParameterGeneration
{
    // ReSharper disable once InconsistentNaming
    public class IsPOCO : AllowCreationWhenAutomating
    {
        public IsPOCO()
            : base("This parameter is a POCO")
        {
        }
    }
}
