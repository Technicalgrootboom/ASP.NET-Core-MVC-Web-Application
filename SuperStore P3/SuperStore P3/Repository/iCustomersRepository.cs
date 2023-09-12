using EcoPower_Logistics.Repository;

namespace EcoPower_Logistics.Repository
{
    public interface iCustomersRepository: IGenericRepository<Service>
    {
        Service GetMostRecentService();
    }
}
