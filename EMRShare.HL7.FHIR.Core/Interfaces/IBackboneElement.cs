namespace HL7.FHIR.Core.Interfaces;

public interface IBackboneElement : IElement
{
    // Used as structural elements inside resources
    string? ModifierExtension { get; set; } // Could be a list of extensions or a single modifier extension
    new string? Id { get; set; } // Inherited from IElement
    new List<object>? Extension { get; set; } 
        
}