namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_PractitionerRoleValueSet
{
    public static readonly Dictionary<string, string> CodeToDisplay = new()
    {
        { "author", "文書作成者" },
        { "referring", "紹介元医師" },
        { "receiving", "紹介先医師" }
    };

    public static string GetDisplay(string code)
    {
        return CodeToDisplay.TryGetValue(code, out var display) ? display : code;
    }

    public static bool IsValid(string code)
    {
        return CodeToDisplay.ContainsKey(code);
    }

    public static IEnumerable<string> AllCodes() => CodeToDisplay.Keys;
    public static IEnumerable<string> AllDisplays() => CodeToDisplay.Values;
}
