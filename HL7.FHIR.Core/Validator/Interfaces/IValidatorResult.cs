namespace HL7.FHIR.Core.Validator.Interfaces;

/// <summary>
/// Represents the result of a validation process.
/// Contains information about whether the validation was successful and any errors encountered.
/// </summary> <summary>
/// 
/// </summary>
public interface IValidatorResult
{
    /// <summary>
    ///     Indicates whether the validation was successful.
    /// If true, the validation passed without errors.
    /// If false, the validation failed and errors can be retrieved.
    /// </summary>
    bool IsValid { get; }
    /// <summary>
    /// Represents a collection of error messages encountered during validation.
    /// If the validation was successful, this collection will be empty.
    /// If the validation failed, this collection will contain one or more error messages describing the issues found.
    /// </summary>
    IEnumerable<string> Errors { get; }
}