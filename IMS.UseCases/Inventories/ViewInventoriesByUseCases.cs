using IMS.CoreBuisness;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories
{
    public class ViewInventoriesByUseCases : IViewInventoriesByUseCases


    {

        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesByUseCases(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }



        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {


            return await inventoryRepository.GetInventoryByNameAsync(name);
        }

    }
}
