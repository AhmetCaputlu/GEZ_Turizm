using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.Employees;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.EmployeeR
{
    public class GenericEmployeeRepository<TEntity, TFilteredEntity> : GenericRepository<TEntity, TFilteredEntity>, IGenericEmployeeRepository<TEntity, TFilteredEntity> where TEntity : BaseEmployeeModel where TFilteredEntity : BaseEmployeeFilterModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<TEntity> _dbset;
        public GenericEmployeeRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }


        public override IQueryable<TEntity> GetDynamicFilteredEntities(TFilteredEntity filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);

            if (!string.IsNullOrEmpty(filterModel.Name))
            {
                filter = filter.Where(x => x.FullName.ToLower().Contains(filterModel.Name.ToLower()));
            }
            if (filterModel.Gender.HasValue)
            {
                filter = filter.Where(x => x.Gender == filterModel.Gender.Value);
            }
            if (filterModel.BirthDate.HasValue)
            {
                filter = filter.Where(x => x.BirthDate.Date == filterModel.BirthDate.Value.Date);
            }
            if (filterModel.Age.HasValue)
            {
                filter = filter.Where(x => (x.Age ?? 0) == filterModel.Age.Value);
            }
            if (filterModel.HireDate.HasValue)
            {
                filter = filter.Where(x => x.HireDate.Date == filterModel.HireDate.Value.Date);
            }
            if (filterModel.Experience.HasValue)
            {
                filter = filter.Where(x => x.Experience == filterModel.Experience.Value);
            }
            return filter;
        }
    }
}
