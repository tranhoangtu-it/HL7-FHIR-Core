using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;
using HL7.FHIR.Core.Resources.Medication;
using HL7.FHIR.DLL.DTO;
using HL7.FHIR.DLL.Utils;

namespace HL7.FHIR.DLL.Factories;

public static class MedicationRequestFactory
{
    public static MedicationRequest Create(MedicationRequestDto dto, string patientId)
    {
        return new MedicationRequest
        {
            Id = Guid.NewGuid().ToString().ToLower(),
            Meta = MetaUtil.CreateProfile("http://jpfhir.jp/fhir/eReferral/StructureDefinition/JP_MedicationRequest"),
            Language = "ja",
            Subject = ReferenceUtil.CreateUuid(patientId),
            AuthoredOn = dto.AuthoredDateTime,

            MedicationCodeableConcept = CodeableConceptUtil.Create(
                system: "http://jpfhir.jp/fhir/core/CodeSystem/JP_MedicationCode", 
                code: dto.MedicationCode,
                display: dto.MedicationDisplay,
                text: dto.MedicationText
            ),

            DosageInstruction = new List<Dosage>
            {
                new Dosage
                {
                    Text = dto.TimingText,
                    Timing = TimingUtil.Create(dto.TimingCode, dto.TimingDisplay),
                    Route = CodeableConceptUtil.Create(
                        "http://jpfhir.jp/fhir/core/CodeSystem/route-codes",
                        dto.RouteCode,
                        dto.RouteDisplay,
                        dto.RouteText
                    ),
                    Method = CodeableConceptUtil.Create(
                        "http://jpfhir.jp/fhir/core/CodeSystem/method-codes",
                        dto.MethodCode,
                        dto.MethodDisplay,
                        dto.MethodText
                    ),
                    DoseAndRate = new List<DoseAndRate>
                    {
                        new DoseAndRate
                        {
                            DoseQuantity = QuantityUtil.Create(
                                dto.DoseQuantity,
                                dto.DoseQuantityUnit,
                                dto.DoseQuantityCode
                            )
                        }
                    },
                    Site = !string.IsNullOrWhiteSpace(dto.SiteCode)
                        ? CodeableConceptUtil.Create(
                            "http://jpfhir.jp/fhir/core/CodeSystem/site-codes",
                            dto.SiteCode,
                            dto.SiteDisplay,
                            dto.SiteText
                        )
                        : null
                }
            },

            DispenseRequest = new MedicationRequestDispenseRequest
            {
                ValidityPeriod = PeriodUtil.CreateStartOnly(dto.DoseStart),
                Quantity = QuantityUtil.Create(
                    dto.DispenseRequestQuantity,
                    dto.DispenseRequestUnit,
                    dto.DispenseRequestCode
                ),
                ExpectedSupplyDuration = DurationUtil.Create(
                    dto.ExpectedSupplyDuration,
                    dto.ExpectedSupplyDurationUnit,
                    dto.ExpectedSupplyDurationCode
                ),
                NumberOfRepeatsAllowed = dto.NumberOfRepeatsAllowed
            },

            Note = !string.IsNullOrWhiteSpace(dto.Note)
                ? new List<Annotation> { new Annotation { Text = dto.Note } }
                : null
        };
    }
}