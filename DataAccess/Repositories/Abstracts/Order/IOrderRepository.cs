using DataAccess.Entities.Abstracts;

namespace DataAccess.Repositories.Abstracts.Order
{
    public interface IOrderRepository<T> : IRepository<T> where T : BaseOrderModel
    {
        IQueryable<T> GetOrderByNote(string note);
        IQueryable<T> GetOrderByEmail(string email);
    }
}
