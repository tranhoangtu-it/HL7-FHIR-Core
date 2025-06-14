using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.DataTypes;

namespace HL7.FHIR.Core.Resources.Financial;

public class ExplanationOfBenefit : DomainResourceBase
{
    public override string ResourceType => "ExplanationOfBenefit";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }
    public CodeableConcept? Type { get; set; }
    public Reference? Patient { get; set; }
    public Period? BillablePeriod { get; set; }
    public DateTime? Created { get; set; }
    public Reference? Insurer { get; set; }
    public Reference? Provider { get; set; }
    public Money? Total { get; set; }
}