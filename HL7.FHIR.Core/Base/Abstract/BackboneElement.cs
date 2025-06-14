namespace HL7.FHIR.Core.Base.Abstract;

public abstract class BackboneElement : ElementBase
{
    public List<MetaData.Extension>? ModifierExtension { get; set; }
}