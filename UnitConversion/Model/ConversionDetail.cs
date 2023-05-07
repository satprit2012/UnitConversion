using System;
using System.Collections.Generic;

namespace UnitConversion.Model;

public partial class ConversionDetail
{
    public int UnitId { get; set; }

    public string? UnitName { get; set; }

    public string? UnitType { get; set; }

    public string? UnitFormula { get; set; }

    public string? UnitSign { get; set; }
}
