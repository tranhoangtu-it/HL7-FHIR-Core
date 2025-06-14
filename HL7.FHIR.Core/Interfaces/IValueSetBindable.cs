namespace HL7.FHIR.Core.Interfaces;

public interface IValueSetBindable
{
    string? System { get; set; }
    string? Code { get; set; }
    string? Display { get; set; }
}