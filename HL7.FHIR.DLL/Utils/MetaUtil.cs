using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.DLL.Utils;

public static class MetaUtil
{
    public static Meta CreateProfile(string profileUrl)
    {
        return new Meta
        {
            LastUpdated = DateTime.UtcNow,
            Profile = new List<string> { profileUrl }
        };
    }
}