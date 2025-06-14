using System.Text;

namespace HL7.FHIR.Core.Validator.Common;

public static class StringNormalizer
{
    public static string Normalize(string input)
    {
        return input.Trim()
                    .Normalize(NormalizationForm.FormKC)
                    .Replace("　", " "); // Replace full-width space with half-width
    }

        public static string ToHalfWidth(string input)
        {
            if (input == null)
                return string.Empty;
    #if WINDOWS
            return Microsoft.VisualBasic.Strings.StrConv(input, Microsoft.VisualBasic.VbStrConv.Narrow, 0x411) ?? string.Empty;
    #else
            // StrConv is only supported on Windows, so return the input as-is on other platforms
            return input;
    #endif
        }
    
        public static string ToFullWidth(string input)
        {
            if (input == null)
                return string.Empty;
    #if WINDOWS
            return Microsoft.VisualBasic.Strings.StrConv(input, Microsoft.VisualBasic.VbStrConv.Wide, 0x411) ?? string.Empty;
    #else
            // StrConv is only supported on Windows, so return the input as-is on other platforms
            return input;
    #endif
        }
}