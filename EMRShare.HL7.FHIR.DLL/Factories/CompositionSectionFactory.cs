using System.Collections.Generic;
using HL7.FHIR.Core.Resources.Core;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.DLL.Utils;

namespace HL7.FHIR.DLL.Factories;

public class CompositionSectionFactory
{
    public CompositionSection Create(string title, List<ResourceBase> entries)
    {
        return new CompositionSection
        {
            Title = title,
            Entry = entries.Select(e => ReferenceUtil.Create($"urn:uuid:{e.Id}")).ToList()
        };
    }
}
