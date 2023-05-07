using UnitConversion.Model;

namespace UnitConversion.Service
{
    public interface IUnitConversionService
    {
        /// <summary>
        /// To fetch unit rate 
        /// </summary>
        /// <param name="unitConversionModel"></param>
        /// <returns>unit rate conversion</returns>
        public string ConvertUnit(UnitConversionModel unitConversionModel);
    }
}
