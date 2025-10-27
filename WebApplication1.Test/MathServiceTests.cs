using Xunit;
using WebApplication1; 

namespace WebApplication1.Tests
{
    public class MathServiceTests 
    {
        [Fact] // Атрибут, що позначає цей метод як тест
        public void Sum_ReturnsCorrectValue()
        {
            // Arrange (Підготовка)
            var service = new MathService();

            // Act (Дія)
            var result = service.Sum(2, 3);

            // Assert (Перевірка)
            Assert.Equal(5, result);
        }
    }
}