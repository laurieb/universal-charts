namespace LAB.UniversalCharts.Core
{
    public interface IConvert
    {
        double ConvertToMetric(double measurement);
        double ConvertToImperial(double measurement);
    }
}
