// Це файл: WebApplication1.Tests/UnitTest1.cs

using Xunit;
using WebApplication1; // <--- ВАЖЛИВО: Додаємо using, щоб "бачити" MathService

namespace WebApplication1.Tests
{
    public class MathServiceTests // Я перейменував клас
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