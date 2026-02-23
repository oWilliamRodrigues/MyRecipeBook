using MyRecipeBook.Domain.Dtos;
using MyRecipeBook.Domain.Enums;
using MyRecipeBook.Domain.Services.GoogleAI;

namespace MyRecipeBook.Domain.Services.GoogleAI
{
    public class MockGoogleAIService : IGenerateRecipeAI
    {
        public Task<GeneratedRecipeDto> Generate(IList<string> ingredients)
        {
            var recipe = new GeneratedRecipeDto
            {
                Title = "Simulação de Receita",
                Ingredients = ingredients,
                CookingTime = CookingTime.Greater_60_Minutes,
                Instructions = new List<GeneratedInstructionDto>
            {
                new GeneratedInstructionDto { Step = 1, Text = "Misture todos os ingredientes." },
                new GeneratedInstructionDto { Step = 2, Text = "Cozinhe por 20 minutos." },
                new GeneratedInstructionDto { Step = 3, Text = "Sirva quente." }
            }
            };

            Console.WriteLine($"Simulando a geração de receita para os ingredientes: {string.Join(", ", ingredients)}");

            return Task.FromResult(recipe);
        }
    }
}
