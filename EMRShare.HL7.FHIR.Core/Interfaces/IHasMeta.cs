using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Interfaces;

public interface IHasMeta
{
    Meta? Meta { get; set; }
}
