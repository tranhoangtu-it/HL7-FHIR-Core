public class MedicationRequestDto
{
    public int RpNo { get; set; }
    public int OrderInRp { get; set; }

    public string? CategoryCode { get; set; }
    public string? CategoryDisplay { get; set; }

    public string? MedicationCode { get; set; }
    public string? MedicationDisplay { get; set; }
    public string? MedicationText { get; set; }

    public DateTime? AuthoredDateTime { get; set; }
    public string? Note { get; set; }

    public DateTime? DoseStart { get; set; }
    public decimal? DoseQuantity { get; set; }
    public string? DoseQuantityUnit { get; set; }
    public string? DoseQuantityCode { get; set; }

    public decimal? DispenseRequestQuantity { get; set; }
    public string? DispenseRequestUnit { get; set; }
    public string? DispenseRequestCode { get; set; }

    public int? DivCnt { get; set; }
    public int? ExpectedSupplyDuration { get; set; }
    public string? ExpectedSupplyDurationUnit { get; set; }
    public string? ExpectedSupplyDurationCode { get; set; }

    public int? Cnt { get; set; }

    public string? TimingCode { get; set; }
    public string? TimingDisplay { get; set; }
    public string? TimingText { get; set; }

    public string? DonpukuYn { get; set; }

    public string? SiteCode { get; set; }
    public string? SiteDisplay { get; set; }
    public string? SiteText { get; set; }

    public string? RouteCode { get; set; }
    public string? RouteDisplay { get; set; }
    public string? RouteText { get; set; }

    public string? MethodCode { get; set; }
    public string? MethodDisplay { get; set; }
    public string? MethodText { get; set; }

    public int? NumberOfRepeatsAllowed { get; set; }

    public string? SubstNotAllowedCode { get; set; }
    public string? SubstNotAllowedDisplay { get; set; }

    public string? EmergencyCode { get; set; }
    public string? EmergencyDisplay { get; set; }

    public string? CrushCode { get; set; }
    public string? CrushDisplay { get; set; }

    public string? PackageCode { get; set; }
    public string? PackageDisplay { get; set; }
}