namespace HL7.FHIR.Core.Validator.Common;

public static class RequiredFieldChecker
{
    public static void CheckRequired(string? value, string fieldName, List<string> errors)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            errors.Add($"\"{fieldName}\" is required.");
        }
    }

    public static void CheckRequired<T>(T? obj, string fieldName, List<string> errors) where T : class
    {
        if (obj == null)
        {
            errors.Add($"\"{fieldName}\" is required.");
        }
    }

    public static void CheckRequiredCollection<T>(IEnumerable<T>? collection, string fieldName, List<string> errors)
    {
        if (collection == null || !collection.Any())
        {
            errors.Add($"\"{fieldName}\" collection must not be empty.");
        }
    }
}