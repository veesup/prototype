using Interfaces;
using Models;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private IPContext _repositoryContext;

        private IProductRepository _productRepository;
        private IOrderRepository _orderRepository;

        public RepositoryManager(IPContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository is null)
                    _productRepository = new ProductRepository(_repositoryContext);

                return _productRepository;
            }
        }

        public IOrderRepository Order
        {
            get
            {
                if (_orderRepository is null)
                    _orderRepository = new OrderRepository(_repositoryContext);

                return _orderRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}
