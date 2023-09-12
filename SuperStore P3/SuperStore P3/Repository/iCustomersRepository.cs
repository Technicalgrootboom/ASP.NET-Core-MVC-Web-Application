using EcoPower_Logistics.Repository;
using Models;

namespace EcoPower_Logistics.Repository
{
    public interface iCustomersRepository: IGenericRepository<Customer>
    {
        Customer GetMostRecentService();
    }
}

