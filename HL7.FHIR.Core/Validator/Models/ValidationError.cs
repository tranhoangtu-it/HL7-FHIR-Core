namespace HL7.FHIR.Core.Validator.Models;

public class ValidationError
{
    public string FieldName { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string? Code { get; set; } // Optional error code
}