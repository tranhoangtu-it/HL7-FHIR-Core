using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;
using HL7.FHIR.Core.Resources.Core;

namespace HL7.FHIR.Core.Resources.Customs.JP;

public class JP_Composition_eReferral : Composition
{
    public JP_Composition_eReferral()
    {
        this.Meta = new Meta
        {
            Profile = new List<string>
            {
                "http://jpfhir.jp/fhir/eReferral/StructureDefinition/JP_Composition_eReferral"
            }
        };
        this.Status = "final";
        this.Type = new CodeableConcept
        {
            Coding = new List<Coding>
            {
                new Coding
                {
                    System = "http://jpfhir.jp/fhir/core/CodeSystem/doc-typecodes",
                    Code = "11506-3",
                    Display = "診療情報提供書"
                }
            }
        };
        this.Title = "診療情報提供書";
    }
} 