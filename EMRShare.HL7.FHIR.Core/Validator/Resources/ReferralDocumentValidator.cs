using HL7.FHIR.Core.Validator.Models;
using HL7.FHIR.Core.Validator.Interfaces;
using HL7.FHIR.Core.Validator.Common;
using HL7.FHIR.Core.Validator.Rules.Document;
using HL7.FHIR.Core.Validator.Rules.Patient;
using HL7.FHIR.Core.Validator.Rules.Shared;
using HL7.FHIR.Core.Resources.Customs.JP;
using HL7.FHIR.Core.Constants;

namespace HL7.FHIR.Core.Validator.Resources.Customs;

public class ReferralDocumentValidator : IValidator<JPReferralDocument>
{
    public ValidatorResult Validate(JPReferralDocument input)
    {
        var result = new ValidatorResult();

        if (!DocumentProfileBindingRule.IsValidProfile(input.Meta?.Profile?.FirstOrDefault()))
            result.AddError("Meta.Profile", ErrorMessages.INVALID, ErrorCodes.INVALID);

        // if (string.IsNullOrWhiteSpace(input.Identifier?.System) || string.IsNullOrWhiteSpace(input.Identifier?.Value))
        //     result.AddError("Identifier", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        // if (!DocumentRequiredFieldsRule.HasValidType(input.Type?.System, input.Type?.Code))
        //     result.AddError("Type", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        // if (!DocumentRequiredFieldsRule.HasValidSubject(input.Subject?.Reference))
        //     result.AddError("Subject.Reference", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        // if (!DocumentRequiredFieldsRule.HasValidCustodian(input.Custodian?.Reference))
        //     result.AddError("Custodian.Reference", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        // if (input.Author?.Identifier != null)
        // {
        //     var authorIdentifier = input.Author.Identifier?.FirstOrDefault();
        //     if (authorIdentifier != null && !PractitionerLicenseRule.IsLicenseValid(authorIdentifier.Value))
        //         result.AddError("Author.Practitioner.Identifier", ErrorMessages.INVALID, ErrorCodes.INVALID);

        //     if (!PractitionerKanaNameRule.HasKanaName(input.Author.FamilyKana, input.Author.Practitioner.GivenKana))
        //         result.AddError("Author.Practitioner.NameKana", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);
        // }

        // if (input.Patient != null)
        // {
        //     if (!PatientKanaRequiredRule.HasKanaName(input.Patient.FamilyKana, input.Patient.GivenKana))
        //         result.AddError("Patient.NameKana", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        //     if (!PatientBirthDateRule.IsValidBirthDate(input.Patient.BirthDate))
        //         result.AddError("Patient.BirthDate", ErrorMessages.INVALID, ErrorCodes.INVALID);
        // }

        return result;
    }
}