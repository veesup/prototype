using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllClients(bool trackChanges);
    }
}
