using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.Vehicles;
using DataAccess.Repositories.Abstracts.Vehicle;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.Vehicle
{
    public class GenericVehicleRepository<TEntity, TFilterEntity> : GenericRepository<TEntity, TFilterEntity>, IGenericVehicleRepository<TEntity, TFilterEntity> where TEntity : BaseVehicleModel where TFilterEntity : BaseVehicleFilterModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<TEntity> _dbset;
        public GenericVehicleRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }
        public override IQueryable<TEntity> GetDynamicFilteredEntities(TFilterEntity filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);

            if (filterModel.VehicleType.HasValue)
            {
                filter = filter.Where(x => x.VehicleType == filterModel.VehicleType.Value);
            }
            if (!string.IsNullOrEmpty(filterModel.LicensePlate))
            {
                filter = filter.Where(x => x.LicensePlate.ToLower().Contains(filterModel.LicensePlate.ToLower()));
            }
            if (!string.IsNullOrEmpty(filterModel.Model))
            {
                filter = filter.Where(x => x.Model != null && x.Model.ToLower().Contains(filterModel.Model.ToLower()));
            }
            if (filterModel.Available == true)
            {
                filter = filter.Where(x => x.IsAvailable == true);
            }

            return filter;
        }
    }
}
