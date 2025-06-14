using HL7.FHIR.Core.Validator.Interfaces;

namespace HL7.FHIR.Core.Validator.Models;

public class ValidatorResult : IValidatorResult
{
    public bool IsValid => !Errors.Any() && !DetailedErrors.Any();

    public List<string> Errors { get; set; } = new();
    IEnumerable<string> IValidatorResult.Errors => Errors;

    public List<ValidationError> DetailedErrors { get; set; } = new();

    public void AddError(string message) => Errors.Add(message);

    public void AddError(string field, string message, string? code = null)
    {
        DetailedErrors.Add(new ValidationError
        {
            FieldName = field,
            Message = message,
            Code = code
        });
    }

    public void AddErrors(IEnumerable<string> messages) => Errors.AddRange(messages);

    public void AddDetailedErrors(IEnumerable<ValidationError> errors) => DetailedErrors.AddRange(errors);
}