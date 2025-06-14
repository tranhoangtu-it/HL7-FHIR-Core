using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.DLL.Utils;

public static class PeriodUtil
{
    public static Period? CreateStartOnly(DateTime? start)
    {
        if (start == null) return null;

        return new Period
        {
            Start = start
        };
    }
}