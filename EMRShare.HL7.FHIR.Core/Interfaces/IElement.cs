namespace HL7.FHIR.Core.Interfaces;

public interface IElement
{
    string? Id { get; set; }
    List<object>? Extension { get; set; } // or strongly-typed Extension
}