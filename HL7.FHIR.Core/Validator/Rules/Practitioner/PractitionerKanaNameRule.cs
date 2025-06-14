public static class PractitionerKanaNameRule
{
    public static bool HasKanaName(string? familyKana, string? givenKana)
    {
        return !string.IsNullOrWhiteSpace(familyKana) || !string.IsNullOrWhiteSpace(givenKana);
    }
}