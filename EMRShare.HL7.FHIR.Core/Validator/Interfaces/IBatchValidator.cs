using HL7.FHIR.Core.Validator.Models;

namespace HL7.FHIR.Core.Validator.Interfaces;

public interface IBatchValidator<T>
{
    IEnumerable<ValidatorResult> Validate(IEnumerable<T> inputs);
}