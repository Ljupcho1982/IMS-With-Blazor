using IMS.CoreBuisness;

namespace IMS.UseCases.Inventories.Interfaces
{
    public interface IViewInventoriesByUseCases
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}