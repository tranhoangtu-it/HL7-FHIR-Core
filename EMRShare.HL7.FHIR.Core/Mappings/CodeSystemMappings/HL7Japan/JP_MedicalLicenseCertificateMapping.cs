using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;
public static class JP_MedicalLicenseCertificateMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_MedicalLicenseCertificate";
    private static readonly Dictionary<JP_MedicalLicenseCertificate, (string code, string display)> Map = new()
    {
        { JP_MedicalLicenseCertificate.Physician, ("Physician", "医師") },
        { JP_MedicalLicenseCertificate.Dentist, ("Dentist", "歯科医師") },
        { JP_MedicalLicenseCertificate.Pharmacist, ("Pharmacist", "薬剤師") },
        { JP_MedicalLicenseCertificate.Nurse, ("Nurse", "看護師") },
        { JP_MedicalLicenseCertificate.Therapist, ("Therapist", "療法士") },
        { JP_MedicalLicenseCertificate.Other, ("Other", "その他") },
    };
    public static string? GetCode(JP_MedicalLicenseCertificate type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_MedicalLicenseCertificate type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_MedicalLicenseCertificate? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_MedicalLicenseCertificate type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}