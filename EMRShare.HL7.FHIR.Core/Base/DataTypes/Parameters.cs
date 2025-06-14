using HL7.FHIR.Core.Base.Abstract;

public class Parameters : ResourceBase
{
    public List<ParameterComponent> Parameter { get; set; } = new();
    public override string ResourceType => "Parameters";
}
