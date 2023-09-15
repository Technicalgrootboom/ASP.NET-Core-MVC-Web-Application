using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class ProductsRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        // GET ALL: Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’

    }
}
