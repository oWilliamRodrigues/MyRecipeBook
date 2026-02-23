using Moq;
using MyRecipeBook.Domain.Dtos;
using MyRecipeBook.Domain.Services.GoogleAI;

namespace CommonTestUtilities.GoogleAI
{
    public class GenerateRecipeAIBuilder
    {
        public static IGenerateRecipeAI Build(GeneratedRecipeDto dto)
        {
            var mock = new Mock<IGenerateRecipeAI>();

            mock.Setup(service => service.Generate(It.IsAny<List<string>>())).ReturnsAsync(dto);

            return mock.Object;
        }
    }
}
