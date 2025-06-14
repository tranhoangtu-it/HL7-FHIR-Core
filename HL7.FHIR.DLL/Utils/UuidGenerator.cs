using System;

namespace HL7.FHIR.DLL.Utils;

public static class UuidGenerator
{
    public static string GenerateUrnUuid() => $"urn:uuid:{Guid.NewGuid()}";
}