using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Activities;
using DataAccess.Repositories.Abstracts.Activity;

namespace DataAccess.Repositories.Concretes.Activity
{
    public class TourRepository : GenericActivityRepository<Tour>, IGenericActivityRepository<Tour>, ITourRepository
    {
        private readonly GezTurizmContext _context;
        public TourRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }
        public IQueryable<Tour> GetToursByTourCategory(TourCategory tourCategory)
        {
            return _context.Tours.Where(x => x.TourCategory == tourCategory);
        }
    }
}
