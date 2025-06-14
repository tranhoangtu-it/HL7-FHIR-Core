public static class DosageInstructionMethodCodeRule
{
    public static bool HasValidMethodCode(string? code)
    {
        return !string.IsNullOrWhiteSpace(code);
    }
}