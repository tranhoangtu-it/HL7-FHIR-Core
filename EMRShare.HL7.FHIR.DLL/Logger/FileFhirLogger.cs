// 📁 HL7.FHIR.DLL/Logger/FileFhirLogger.cs
using System;
using System.IO;
using System.Text;

namespace HL7.FHIR.DLL.Logger;

public class FileFhirLogger : IFhirLogger
{
    private readonly string _logDirectory;

    public FileFhirLogger(string logDirectory = "Logs")
    {
        _logDirectory = logDirectory;
        Directory.CreateDirectory(_logDirectory);
    }

    private string GetLogFilePath()
    {
        var date = DateTime.Now.ToString("yyyyMMdd");
        return Path.Combine(_logDirectory, $"fhir_log_{date}.log");
    }

    private void WriteLine(string level, string message)
    {
        var log = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}";
        try
        {
            File.AppendAllText(GetLogFilePath(), log + Environment.NewLine, Encoding.UTF8);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[LOGGER ERROR] Failed to write log: {ex.Message}");
        }
    }

    public void Info(string message) => WriteLine("INFO", message);
    public void Warn(string message) => WriteLine("WARN", message);

    public void Error(string message, Exception? ex = null)
    {
        var fullMessage = ex != null ? $"{message} | Exception: {ex.Message}\n{ex.StackTrace}" : message;
        WriteLine("ERROR", fullMessage);
    }

    public void Debug(string message)
    {
#if DEBUG
        WriteLine("DEBUG", message);
#endif
    }
}
