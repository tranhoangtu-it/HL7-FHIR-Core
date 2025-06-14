using HL7.FHIR.Core.Validator.Models;

namespace HL7.FHIR.Core.Validator.Interfaces;

/// <summary>
/// IValidator interface for validating a single input of type T.
/// This interface defines a method to validate an input and return a result.
/// The result is encapsulated in a ValidatorResult object, which contains information about the validation outcome.
/// </summary>
public interface IValidator<T>
{
    ValidatorResult Validate(T input);
}