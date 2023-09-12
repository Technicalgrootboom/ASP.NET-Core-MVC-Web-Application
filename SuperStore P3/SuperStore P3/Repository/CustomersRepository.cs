using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class CustomersRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        // GET ALL: Products
        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’
    }

}
}
