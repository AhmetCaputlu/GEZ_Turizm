using DataAccess.Entities.Abstracts;

namespace DataAccess.Repositories.Abstracts.Order
{
    public interface IGenericOrderRepository<T> : IGenericRepository<T> where T : BaseOrderModel
    {
        IQueryable<T> GetOrderByNote(string note);
        IQueryable<T> GetOrderByEmail(string email);
    }
}
