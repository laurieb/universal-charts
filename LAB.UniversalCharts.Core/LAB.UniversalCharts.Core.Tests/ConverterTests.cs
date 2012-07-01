using Xunit;

namespace LAB.UniversalCharts.Core.Tests
{
    public class ConverterTests
    {
        [Fact]
        public void ConvertToMetric_StandardBehaviour_ReturnsDouble()
        {
            IConvert converter = new Converter();
            var result = converter.ConvertToMetric(10);
            Assert.IsType<double>(result);

        }
    }
}
