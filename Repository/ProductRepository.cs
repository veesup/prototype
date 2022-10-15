using Interfaces;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class ProductRepository : RepositoryBase<IPContext, Product>, IProductRepository
    {
        public ProductRepository(IPContext clientContext)
            : base(clientContext)
        {
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges) =>
            FindAll(trackChanges)
            .ToList();

    }
}