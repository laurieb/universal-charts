namespace LAB.UniversalCharts.Core
{
    public class Converter : IConvert
    {
        private const double ConversionFactor = 2;

        public double ConvertToMetric(double measurement)
        {
            return measurement*ConversionFactor;
        }

        public double ConvertToImperial(double measurement)
        {
            throw new System.NotImplementedException();
        }
    }
}
