using Xunit;

namespace LAB.UniversalCharts.Core.Tests
{
    public class HelloWorldTests
    {
        [Fact]
        public void TestHelloWorld()
        {
            var helloWorld = new HelloWorld();
            var response = helloWorld.SayHelloWorld();
            Assert.Equal("hello world", response);
        }
    }
}
