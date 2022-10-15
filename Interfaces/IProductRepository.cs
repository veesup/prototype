using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
    }
}
