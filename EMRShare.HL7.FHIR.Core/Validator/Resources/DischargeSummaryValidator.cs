using HL7.FHIR.Core.Validator.Models;
using HL7.FHIR.Core.Validator.Interfaces;
using HL7.FHIR.Core.Validator.Common;
using HL7.FHIR.Core.Validator.Rules.Document;
using HL7.FHIR.Core.Validator.Rules.Encounter;
using HL7.FHIR.Core.Validator.Rules.Shared;
using HL7.FHIR.Core.Validator.Rules.Patient;
using HL7.FHIR.Core.Resources.Customs.JP;
using HL7.FHIR.Core.Constants;

namespace HL7.FHIR.Core.Validator.Resources.Customs;

public class DischargeSummaryValidator : IValidator<JPDischargeSummary>
{
    public ValidatorResult Validate(JPDischargeSummary input)
    {
        var result = new ValidatorResult();

        // if (!DocumentProfileBindingRule.IsValidProfile(input.Meta?.Profile))
        //     result.AddError("Meta.Profile", ErrorMessages.INVALID, ErrorCodes.INVALID);

        // if (string.IsNullOrWhiteSpace(input.Identifier?.System) || string.IsNullOrWhiteSpace(input.Identifier?.Value))
        //     result.AddError("Identifier", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        // if (!DocumentRequiredFieldsRule.HasValidType(input.Type?.System, input.Type?.Code))
        //     result.AddError("Type", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        // if (!DocumentRequiredFieldsRule.HasValidSubject(input.Subject?.Reference))
        //     result.AddError("Subject.Reference", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        // if (input.Context?.Encounter != null)
        // {
        //     var start = input.Context.Encounter.Period?.Start;
        //     var end = input.Context.Encounter.Period?.End;

        //     if (!EncounterDateRangeRule.IsValidPeriod(start, end))
        //         result.AddError("Context.Encounter.Period", ErrorMessages.MISMATCH, ErrorCodes.MISMATCH);
        // }
        // else
        // {
        //     result.AddError("Context.Encounter", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);
        // }

        // if (!DocumentRequiredFieldsRule.HasValidCustodian(input.Custodian?.Reference))
        //     result.AddError("Custodian.Reference", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        // if (input.Author?.Practitioner != null)
        // {
        //     if (!PractitionerLicenseRule.IsLicenseValid(input.Author.Practitioner.Identifier?.Value))
        //         result.AddError("Author.Practitioner.Identifier", ErrorMessages.INVALID, ErrorCodes.INVALID);

        //     if (!PractitionerKanaNameRule.HasKanaName(input.Author.Practitioner.FamilyKana, input.Author.Practitioner.GivenKana))
        //         result.AddError("Author.Practitioner.NameKana", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);
        // }
        // else
        // {
        //     result.AddError("Author.Practitioner", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);
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