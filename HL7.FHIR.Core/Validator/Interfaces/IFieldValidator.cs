namespace HL7.FHIR.Core.Validator.Interfaces;

public interface IFieldValidator<TField>
{
    bool IsValid(TField input);
    string? GetErrorMessage(TField input);
}