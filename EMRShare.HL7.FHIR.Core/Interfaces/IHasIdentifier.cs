using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Interfaces;

public interface IHasIdentifier
{
    List<Identifier>? Identifier { get; set; }
}
