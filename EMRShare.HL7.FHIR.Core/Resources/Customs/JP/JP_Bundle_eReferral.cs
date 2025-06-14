using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Customs.JP;

public class JP_Bundle_eReferral : Bundle
{
    public JP_Bundle_eReferral()
    {
        this.Type = "document";
        this.Meta = new Meta
        {
            Profile = new List<string>
            {
                "http://jpfhir.jp/fhir/clins/StructureDefinition/JP_Bundle_eReferral"
            }
        };
        this.Entry = new List<BundleEntry>();
    }
}