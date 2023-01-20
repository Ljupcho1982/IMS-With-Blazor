using IMS.CoreBuisness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        public Task AddInventoryAsync(Inventory inventory);
        public Task UpdateInventoryAsync(Inventory inventory);
        Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name);

        Task<Inventory> GetInventoryByIdAsync(int InventoryId);

    }
}
