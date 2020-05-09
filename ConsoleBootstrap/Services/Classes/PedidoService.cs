using ConsoleBootstrap.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace ConsoleBootstrap.Services.Classes
{
    public class PedidoService : IPedidoService
    {
        private readonly IItemService itemService;
        private readonly ILogger logger;

        public PedidoService(IItemService itemService, ILogger<PedidoService> logger)
        {
            this.itemService = itemService;
            this.logger = logger;
        }

        public void FecharPedido(long id)
        {
            logger.LogDebug("All done!");
            this.itemService.FecharPedido(id);
            this.logger.LogInformation("Pedido Fechado");
        }
    }
}
