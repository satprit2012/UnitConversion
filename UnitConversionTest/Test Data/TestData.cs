using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConversion.Model;

namespace UnitConversionTest.Test_Data
{
    internal class TestData
    {
        public UnitConversionModel GetUnitData()
        {
            return new UnitConversionModel() {
                unitType = "F",
                unitName = "TEMPERATURE",
                unitValue = 30
            };
           
        }
        public UnitConversionModel GetUnitDataNull()
        {
            return new UnitConversionModel()
            {
                unitType = "",
                unitName = "TEMPERATURE",
                unitValue = 30
            };

        }
    }
}
