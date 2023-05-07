
using Moq;
using UnitConversion.Controllers;
using UnitConversion.Model;
using UnitConversion.Service;
using UnitConversionTest.Test_Data;

namespace UnitConversionTest
{
    public class UnitConversionTest
    {
        private ConversionController controller;
        TestData TestData = new TestData();
        private Mock<IUnitConversionService> mockunitConversionService;
        private UnitConversionService unitConversionService;

        [SetUp]
        public void Setup()
        {
            mockunitConversionService = new Mock<IUnitConversionService>();
            unitConversionService = new UnitConversionService();
            controller = new ConversionController(unitConversionService);
        }

        [Test]
        public void UnitConversionSuccess()
        {
            var str = mockunitConversionService.Setup(x => x.ConvertUnit(TestData.GetUnitData()));
            string result = controller.UnitConversion(TestData.GetUnitData());
            Assert.IsNotNull(result);
        }

        [Test]
        public void UnitConversionException()
        {
            var str = mockunitConversionService.Setup(x => x.ConvertUnit(TestData.GetUnitData())).Throws(new Exception());
            string result = controller.UnitConversion(new UnitConversionModel());
            Assert.IsNotNull(new Exception());
        }

        [Test]
        public void UnitConversionReturnNull()
        {
            var str = mockunitConversionService.Setup(x => x.ConvertUnit(TestData.GetUnitData()));
            string result = controller.UnitConversion(TestData.GetUnitDataNull());
            Assert.IsNotNull(result);
        }

    }
}