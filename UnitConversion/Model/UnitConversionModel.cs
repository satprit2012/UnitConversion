using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace UnitConversion.Model
{
    [ExcludeFromCodeCoverage]
    public class UnitConversionModel
    {
        [Display(Name = "Unit Name")]
        public string unitName { get; set; }

        [Display(Name = "Unit Type")]
        public string unitType { get; set; }

        [Display(Name = "Unit Value")]
        public double unitValue { get; set; }
    }
}
