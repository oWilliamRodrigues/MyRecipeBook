using MyRecipeBook.Domain.Dtos;

namespace MyRecipeBook.Domain.Services.GoogleAI
{
    public interface IGenerateRecipeAI
    {
        Task<GeneratedRecipeDto> Generate(IList<string> ingredients);
    }
}
