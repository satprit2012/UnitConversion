using Microsoft.AspNetCore.Mvc;
using UnitConversion.Model;
using UnitConversion.Service;

namespace UnitConversion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversionController : ControllerBase
    {
       public readonly IUnitConversionService unitConversionService;
       public ConversionController(IUnitConversionService iunit)
        {
            unitConversionService = iunit;
        }

        /// <summary>
        /// UnitConversion
        /// </summary>
        /// <param name="unitConversionModel"></param>
        /// <returns>Converted to unit string </returns>
        [HttpGet(Name = "CalculateUnit")]
        public string UnitConversion([FromQuery]UnitConversionModel unitConversionModel)
        {
          return unitConversionService.ConvertUnit(unitConversionModel);
        }
    }
}
