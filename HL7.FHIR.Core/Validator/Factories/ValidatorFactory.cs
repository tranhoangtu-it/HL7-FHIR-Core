using System;
using HL7.FHIR.Core.Resources.Customs.JP;
using HL7.FHIR.Core.Validator.Interfaces;
using HL7.FHIR.Core.Validator.Resources.Customs;

namespace HL7.FHIR.Core.Validator.Factories;

/// <summary>
/// Factory để resolve validator phù hợp dựa trên resource type hoặc generic type.
/// </summary>
public static class ValidatorFactory
{
    /// <summary>
    /// Resolve validator dựa vào tên resource (string).
    /// </summary>
    /// <param name="resourceType">Tên resource, ví dụ: "ReferralDocument"</param>
    /// <returns>IValidator phù hợp hoặc null nếu không tìm thấy</returns>
    public static IValidator<object>? Resolve(string resourceType)
    {
        if (string.IsNullOrWhiteSpace(resourceType))
            return null;

        return resourceType.Trim() switch
        {
            nameof(JPReferralDocument) => new ReferralDocumentValidator() as IValidator<object>,
            nameof(JPDischargeSummary) => new DischargeSummaryValidator() as IValidator<object>,
            nameof(JPCheckupResult) => new CheckupResultValidator() as IValidator<object>,
            _ => null
        };
    }

    /// <summary>
    /// Resolve validator dựa vào kiểu generic T.
    /// </summary>
    /// <typeparam name="T">Kiểu tài liệu đầu vào</typeparam>
    /// <returns>IValidator<T> tương ứng hoặc null nếu không hỗ trợ</returns>
    public static IValidator<T>? Resolve<T>()
    {
        var type = typeof(T);

        if (type == typeof(JPReferralDocument)) return new ReferralDocumentValidator() as IValidator<T>;
        if (type == typeof(JPDischargeSummary)) return new DischargeSummaryValidator() as IValidator<T>;
        if (type == typeof(JPCheckupResult)) return new CheckupResultValidator() as IValidator<T>;

        return null;
    }

    /// <summary>
    /// Danh sách tất cả resource types được hỗ trợ trong factory.
    /// </summary>
    public static IReadOnlyList<string> SupportedTypes => new List<string>
    {
        nameof(JPReferralDocument),
        nameof(JPDischargeSummary),
        nameof(JPCheckupResult)
    };
}