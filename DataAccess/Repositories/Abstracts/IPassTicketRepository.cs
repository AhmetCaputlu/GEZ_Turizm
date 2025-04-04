using DataAccess.Entities.Abstracts;

namespace DataAccess.Repositories.Abstracts
{
    public interface IPassTicketRepository<T> : IRepository<T> where T : BasePassTicketModel
    {
        IQueryable<T> GetPassTicketByPriceDesc();
        IQueryable<T> GetPassTicketByTotalCostDesc();
    }
}
