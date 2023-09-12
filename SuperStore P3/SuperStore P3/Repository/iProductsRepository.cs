using EcoPower_Logistics.Repository;

namespace EcoPower_Logistics.Repository
{
    public interface iProductsRepository : IGenericRepository<ProductsRepository>
    {
        ProductsRepository GetMostRecentService();
    }
}
