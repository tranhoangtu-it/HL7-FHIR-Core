using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Interfaces;

public interface IReferenceable
{
    Reference ToReference();
}