using MathNet.Numerics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using UnitConversion.Model;
using System.Data;
using System.IO;

namespace UnitConversion.Service
{

    public class UnitConversionService : IUnitConversionService
    {
        /// <summary>
        /// ConvertUnit
        /// </summary>
        /// <param name="unitConversionModel"></param>
        /// <returns>Result string for unit</returns>
        public string ConvertUnit(UnitConversionModel unitConversionModel)
        {
            string? Result = "";
            try
            {
                UnitConversionContext unitConversionContext = new UnitConversionContext();

                var conversionRate = (from s in unitConversionContext.ConversionDetails.ToList()
                                      where s.UnitType.Trim() == unitConversionModel.unitType.ToUpper() &&
                                      s.UnitName.Trim() == unitConversionModel.unitName.ToUpper()
                                      select s).FirstOrDefault();

                if (conversionRate != null && unitConversionModel?.unitValue != null && !string.IsNullOrEmpty(conversionRate.UnitFormula))
                {
                    string? formula = conversionRate.UnitFormula.ToString();
                    string? ConvertedValue = Regex.Replace(formula, "[a-zA-Z]", unitConversionModel.unitValue.ToString());
                    Result = new DataTable().Compute(ConvertedValue, null).ToString();
                    Result = Math.Round(Convert.ToDecimal(Result)) + conversionRate.UnitSign;
                }
                else
                {
                    Result = "No data found";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return Result;
        }
    }
}
