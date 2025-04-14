using DataAccess.Entities.Abstracts;

namespace DataAccess.Repositories.Abstracts.PassTicket
{
    public interface IGenericPassTicketRepository<T> : IGenericRepository<T> where T : BasePassTicketModel
    {
        IQueryable<T> GetPassTicketByPriceDesc();
        IQueryable<T> GetPassTicketByTotalCostDesc();
    }
}
