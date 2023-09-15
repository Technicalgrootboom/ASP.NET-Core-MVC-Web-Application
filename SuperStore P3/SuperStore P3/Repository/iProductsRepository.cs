using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Repository
{
    public interface iProductsRepository : IGenericRepository<Product>
    {
        Product GetMostRecentService();
    }
}
