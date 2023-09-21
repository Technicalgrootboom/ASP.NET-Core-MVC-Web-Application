using Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailsRepository : GenericRepository<OrderDetail>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(SuperStoreContext context) : base(context)
        {
        }

        public OrderDetail GetMostRecentOrderDetails()
        {
            return _context.OrderDetails.OrderByDescending(orderdetail => orderdetail.OrderDetailsId).FirstOrDefault();
        }
    }
}
