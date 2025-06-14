using System;

namespace HL7.FHIR.DLL.DTO.Components;

public class CheckupDto
{
    // Composition
    public string CompositionReportCode { get; set; }
    public string CompositionReportName { get; set; }
    public string CompositionServiceCode { get; set; }
    public string CompositionServiceName { get; set; }

    // Organization
    public string OrganizationHospitalName { get; set; }
    public string OrganizationHospitalPhone { get; set; }
    public string OrganizationHospitalAddress { get; set; }
    public string OrganizationHospitalPost { get; set; }

    // Coverage
    public string CoverageCode { get; set; }
    public string CoverageNumber { get; set; }
    public string CoverageStartDate { get; set; }
    public string CoverageEndDate { get; set; }

    // Encounter
    public string EncounterCode { get; set; }
    public string EncounterStartDate { get; set; }
    public string EncounterEndDate { get; set; }

    // Observation
    public string ObservationText { get; set; }
    public string ObservationJlac10Code { get; set; }
    public string ObservationJlac10Display { get; set; }
    public string ObservationEffectiveDate { get; set; }
    public string ObservationPerformerIde { get; set; }
    public string ObservationPerformerSyl { get; set; }
    public string ObservationQuantityValue { get; set; }
    public string ObservationQuantityUnit { get; set; }
    public string ObservationQuantityCode { get; set; }
    public string ObservationCodeableCode { get; set; }
    public string ObservationCodeableDisplay { get; set; }
    public string ObservationValueDate { get; set; }
    public string ObservationValueText { get; set; }
    public string ObservationAbsentCode { get; set; }
    public string ObservationAbsentDisplay { get; set; }
    public string ObservationAbsentText { get; set; }
    public string ObservationInterpretationCode { get; set; }
    public string ObservationInterpretationDisplay { get; set; }
    public string ObservationNoteText { get; set; }
    public string ObservationMethodCode { get; set; }
    public string ObservationMethodDisplay { get; set; }
    public string ObservationSpecimenType { get; set; }
    public string ObservationSpecimenDisplay { get; set; }

    // Reference Range
    public string ObservationRangeLowValue { get; set; }
    public string ObservationRangeLowUnit { get; set; }
    public string ObservationRangeHighValue { get; set; }
    public string ObservationRangeHighUnit { get; set; }

    // Observation Interpretation (Examiner)
    public string ObservationCompExIde { get; set; }
    public string ObservationCompExSyl { get; set; }
    public string ObservationCompExCode { get; set; }
    public string ObservationCompExDisplay { get; set; }
    public string ObservationCompExText { get; set; }
    public string ObservationCompAbsentCode { get; set; }
    public string ObservationCompAbsentDisplay { get; set; }
    public string ObservationCompAbsentText { get; set; }

    // Media (Image)
    public string MediaContentType { get; set; }
    public string MediaData { get; set; }
    public string MediaUrl { get; set; }
    public string MediaHash { get; set; }
    public string MediaTitle { get; set; }

    // Document (PDF)
    public string DocumentDescription { get; set; }
    public string DocumentContentType { get; set; }
    public string DocumentData { get; set; }
    public string DocumentUrl { get; set; }
    public string DocumentHash { get; set; }
    public string DocumentTitle { get; set; }
    public string DocumentCode { get; set; }
}