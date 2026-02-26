using Azure.Messaging.ServiceBus;

namespace MyRecipeBook.Infrastructure.Services.ServiceBus
{
    public class MockServiceBusProcessor : ServiceBusProcessor
    {
        public override Task StartProcessingAsync(CancellationToken cancellationToken = default)
        {
            Console.WriteLine("Simulando o processamento de mensagens do Service Bus.");
            return Task.CompletedTask;
        }

        public override Task StopProcessingAsync(CancellationToken cancellationToken = default)
        {
            Console.WriteLine("Simulando a parada do processamento de mensagens do Service Bus.");
            return Task.CompletedTask;
        }

        public async Task SimulateMessageProcessing(string message)
        {
            var userIdentifier = Guid.Parse(message);
            Console.WriteLine($"Simulando a exclusão da conta do usuário {userIdentifier}");
        }
    }
}
