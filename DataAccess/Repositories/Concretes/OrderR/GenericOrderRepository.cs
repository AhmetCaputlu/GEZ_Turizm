using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Repositories.Abstracts.Order;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.Order
{
    public class GenericOrderRepository<T> : GenericRepository<T>, IGenericOrderRepository<T> where T : BaseOrderModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<T> _dbset;
        public GenericOrderRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public IQueryable<T> GetOrderByNote(string note)
        {
            return _dbset.Where(x => x.Note != null &&  x.Note.ToLower().Contains(note.ToLower()));
        }

        public IQueryable<T> GetOrderByEmail(string email)
        {
            return _dbset.Where(x => x.WebUserEmail.ToLower().Contains(email.ToLower()));
        }
    }
}
