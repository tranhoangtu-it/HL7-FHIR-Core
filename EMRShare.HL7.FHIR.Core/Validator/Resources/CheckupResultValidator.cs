using HL7.FHIR.Core.Validator.Models;
using HL7.FHIR.Core.Validator.Interfaces;
using HL7.FHIR.Core.Validator.Common;
using HL7.FHIR.Core.Validator.Rules.Document;
using HL7.FHIR.Core.Validator.Rules.Shared;
using HL7.FHIR.Core.Constants;
using HL7.FHIR.Core.Resources.Customs.JP;

namespace HL7.FHIR.Core.Validator.Resources.Customs;

public class CheckupResultValidator : IValidator<JPCheckupResult>
{
    public ValidatorResult Validate(JPCheckupResult input)
    {
        var result = new ValidatorResult();

        if (string.IsNullOrWhiteSpace(input.Id))
            result.AddError("Id", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        if (!CanonicalUrlRule.IsValidCanonical(input.Meta?.Profile?.FirstOrDefault()))
            result.AddError("Meta.Profile", ErrorMessages.INVALID, ErrorCodes.INVALID);

        // if (!DocumentRequiredFieldsRule.HasValidType(input.Type?.System, input.Type?.Code))
        //     result.AddError("Type", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        // if (!DocumentRequiredFieldsRule.HasValidSubject(input.Subject?.Reference))
        //     result.AddError("Subject.Reference", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        // if (!DocumentRequiredFieldsRule.HasValidCustodian(input.Custodian?.Reference))
        //     result.AddError("Custodian.Reference", ErrorMessages.REQUIRED, ErrorCodes.REQUIRED);

        return result;
    }
}