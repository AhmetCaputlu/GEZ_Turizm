using DataAccess.Entities.Abstracts;

namespace DataAccess.Repositories.Abstracts
{
    public interface IOrderDetailRepository<T> : IRepository<T> where T : BaseOrderDetailModel
    {
        IQueryable<T> GetDetailByUnitPriceDesc();
        IQueryable<T> GetDetailByQuantityDesc();
        IQueryable<T> GetTotalCostRange(decimal low,decimal high);
    }
}
