using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders(bool trackChanges);
    }
}
