namespace Interfaces
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        IOrderRepository Order { get; }
        void Save();
    }
}
