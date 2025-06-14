namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_MedicalLicenseCertificateValueSet
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_MedicalLicenseCertificate";

    public static readonly string[] AllowedCodes = new[]
    {
        "Physician",
        "Dentist",
        "Pharmacist",
        "Nurse",
        "Therapist",
        "Other"
    };
}