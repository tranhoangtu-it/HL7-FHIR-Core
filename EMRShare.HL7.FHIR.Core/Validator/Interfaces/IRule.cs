namespace HL7.FHIR.Core.Validator.Interfaces;

public interface IRule<T>
{
    bool IsSatisfied(T input);
    string ErrorMessage { get; }
}