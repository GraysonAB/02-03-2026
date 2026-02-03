
using GB_Basic_App_GitHub;
using Xunit;
namespace GB_Basic_App_Core.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestNameProperty()
        {
            // Arrange
            Class1 tp = new Class1();
            // Act
            var result = tp.Name;
            // Assert
            Assert.Equal("[Grayson Baustert] - The Code Master", result);
        }
    }
}