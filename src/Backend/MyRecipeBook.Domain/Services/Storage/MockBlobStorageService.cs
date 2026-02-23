using MyRecipeBook.Domain.Entities;

namespace MyRecipeBook.Domain.Services.Storage
{
    public class MockBlobStorageService : IBlobStorageService
    {
        public Task Upload(User user, Stream file, string fileName)
        {
            Console.WriteLine($"Simulando upload para o Azure Blob Storage: {fileName}");
            return Task.CompletedTask;
        }

        public Task<string> GetFileUrl(User user, string fileName)
        {
            Console.WriteLine($"Simulando a recuperação da URL para o arquivo: {fileName}");
            return Task.FromResult("https://mockedurl.com/" + fileName);
        }

        public Task Delete(User user, string fileName)
        {
            Console.WriteLine($"Simulando exclusão do arquivo {fileName} no Azure Blob Storage");
            return Task.CompletedTask;
        }

        public Task DeleteContainer(Guid userIdentifier)
        {
            Console.WriteLine($"Simulando exclusão do container do usuário {userIdentifier}");
            return Task.CompletedTask;
        }
    }
}
