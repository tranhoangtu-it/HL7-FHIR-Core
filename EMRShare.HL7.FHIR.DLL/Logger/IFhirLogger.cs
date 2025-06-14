namespace HL7.FHIR.DLL.Logger;

public interface IFhirLogger
{
    void Info(string message);
    void Warn(string message);
    void Error(string message, Exception? ex = null);
    void Debug(string message);
}