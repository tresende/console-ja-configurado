using ConsoleBootstrap.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace ConsoleBootstrap.Services.Classes
{
    public class ItemService : IItemService
    {

        private readonly ILogger logger;

        public ItemService(ILogger<ItemService> logger)
        {
            this.logger = logger;
        }

        public void FecharPedido(long id)
        {
            this.logger.LogInformation($"Pedido #{id} Fechado");
        }
    }
}
