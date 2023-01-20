using IMS.CoreBuisness;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories
{
    public class AddInventoryUseCase : IAddInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRespoistory;
        public AddInventoryUseCase(IInventoryRepository inventoryRespoistory)
        {
            this.inventoryRespoistory = inventoryRespoistory;

        }
        public async Task ExecuteAsync(Inventory inventory)
        {

            this.inventoryRespoistory.AddInventoryAsync(inventory);

        }
    }
}
