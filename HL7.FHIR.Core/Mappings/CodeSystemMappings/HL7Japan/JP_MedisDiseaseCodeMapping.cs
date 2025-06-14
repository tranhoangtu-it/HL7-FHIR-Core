using HL7.FHIR.Core.CodeSystems.HL7Japan;

namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;

public static class JP_MedisDiseaseCodeMapping
{
    public const string System = "http://medis.or.jp/CodeSystem/master-disease-exCode";
    private static readonly Dictionary<JP_MedisDiseaseCode, (string code, string display)> Map = new()
    {
        { JP_MedisDiseaseCode.C150, ("C150", "食道癌") },
        { JP_MedisDiseaseCode.C160, ("C160", "胃癌") },
        { JP_MedisDiseaseCode.I10, ("I10", "高血圧症") },
        { JP_MedisDiseaseCode.E10, ("E10", "1型糖尿病") },
        { JP_MedisDiseaseCode.E11, ("E11", "2型糖尿病") },
        { JP_MedisDiseaseCode.Z001, ("Z001", "健康診断") },
        { JP_MedisDiseaseCode.U071, ("U071", "COVID-19") },
        { JP_MedisDiseaseCode.Other, ("Other", "その他") },
    };
    public static string? GetCode(JP_MedisDiseaseCode type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_MedisDiseaseCode type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_MedisDiseaseCode? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_MedisDiseaseCode type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}