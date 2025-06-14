using System;

namespace HL7.FHIR.DLL.Logger;

public class FhirLogger : IFhirLogger
{
    public void Info(string message) => Console.WriteLine($"[INFO] {message}");
    public void Warn(string message) => Console.WriteLine($"[WARN] {message}");
    public void Error(string message, Exception? ex = null) =>
        Console.WriteLine($"[ERROR] {message} {(ex != null ? ex.ToString() : "")}");
    public void Debug(string message) =>
#if DEBUG
        Console.WriteLine($"[DEBUG] {message}");
#else
        Console.WriteLine($"[DEBUG] {message}");
#endif
}