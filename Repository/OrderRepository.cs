using Interfaces;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class OrderRepository : RepositoryBase<IPContext, Order>, IOrderRepository
    {
        public OrderRepository(IPContext clientContext)
            : base(clientContext)
        {
        }

        public IEnumerable<Order> GetAllOrders(bool trackChanges) =>
            FindAll(trackChanges)
            .ToList();

    }
}