using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllClients(bool trackChanges);
    }
}
