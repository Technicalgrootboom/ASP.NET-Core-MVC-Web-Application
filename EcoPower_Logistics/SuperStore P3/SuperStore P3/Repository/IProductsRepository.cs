using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IProductsRepository : IGenericRepository<Product>
    {
        Product GetMostRecentProduct();
    }
}
