using DataAccess.Entities.Abstracts;

namespace DataAccess.Repositories.Abstracts.OrderDetail
{
    public interface IGenericOrderDetailRepository<T> : IGenericRepository<T> where T : BaseOrderDetailModel
    {
        IQueryable<T> GetDetailByUnitPriceDesc();
        IQueryable<T> GetDetailByQuantityDesc();
        IQueryable<T> GetTotalCostRange(decimal low, decimal high);
    }
}
