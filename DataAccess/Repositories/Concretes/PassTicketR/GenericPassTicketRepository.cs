using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Repositories.Abstracts.PassTicket;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.PassTicket
{
    public class GenericPassTicketRepository<T> : GenericRepository<T>, IGenericPassTicketRepository<T> where T : BasePassTicketModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<T> _dbset;
        public GenericPassTicketRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public IQueryable<T> GetPassTicketByPriceDesc()
        {
            return _dbset.OrderByDescending(x => x.Price);
        }

        public IQueryable<T> GetPassTicketByTotalCostDesc()
        {
            return _dbset.OrderByDescending(x => x.TotalCostwithCommission);
        }
    }
}
