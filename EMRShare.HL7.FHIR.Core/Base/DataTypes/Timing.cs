using System;
using System.Collections.Generic;

namespace HL7.FHIR.Core.Base.DataTypes;

public class Timing
{
    public List<DateTime>? Event { get; set; }
    public TimingRepeat? Repeat { get; set; }
    public CodeableConcept? Code { get; set; }
}

public class TimingRepeat
{
    public Duration? BoundsDuration { get; set; }
    public Range? BoundsRange { get; set; }
    public Period? BoundsPeriod { get; set; }

    public int? Count { get; set; }
    public int? CountMax { get; set; }

    public decimal? Duration { get; set; }
    public decimal? DurationMax { get; set; }
    public string? DurationUnit { get; set; } // s | min | h | d | wk | mo | a

    public int? Frequency { get; set; }
    public int? FrequencyMax { get; set; }

    public decimal? Period { get; set; }
    public decimal? PeriodMax { get; set; }
    public string? PeriodUnit { get; set; } // s | min | h | d | wk | mo | a

    public List<string>? DayOfWeek { get; set; } // mon | tue | ...
    public List<string>? TimeOfDay { get; set; } // e.g. 08:00, 12:00
    public List<CodeableConcept>? When { get; set; }
    public int? Offset { get; set; } // in minutes
}