using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.FilterModels.BaseModel;
using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Repositories.Abstracts.Company;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.Company
{
    public class GenericCompanyRepository<TEntity, TFilteredEntity> : GenericRepository<TEntity,TFilteredEntity>, IGenericCompanyRepository<TEntity, TFilteredEntity> 
        where TEntity : BaseCompanyModel where TFilteredEntity : BaseCompanyFilterModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<TEntity> _dbset;
        public GenericCompanyRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }
        /// <summary>
        /// Supplier ve PartnerCompany için oluşturulmuş generic sorgu metodu
        /// </summary>
        /// <param name="filterModel"></param>
        /// <returns></returns>
        public override IQueryable<TEntity> GetDynamicFilteredEntities(TFilteredEntity filterModel)
        {
            var filter = base.GetDynamicFilteredEntities(filterModel);

            if (!string.IsNullOrEmpty(filterModel.CompanyName))
            {
                filter = filter.Where(x => x.CompanyName.ToLower().Contains(filterModel.CompanyName.ToLower()));
            }
            if (!string.IsNullOrEmpty(filterModel.ContactName))
            {
                filter = filter.Where(x => x.ContactName.ToLower().Contains(filterModel.ContactName.ToLower()));
            }
            if (!string.IsNullOrEmpty(filterModel.ContactTitle))
            {
                filter = filter.Where(x => x.ContactName.ToLower().Contains(filterModel.ContactTitle.ToLower()));
            }
            if (!string.IsNullOrEmpty(filterModel.Email))
            {
                filter = filter.Where(x => x.Email.ToLower().Contains(filterModel.Email.ToLower()));
            }
            if (!string.IsNullOrEmpty(filterModel.PhoneNumber))
            {
                filter = filter.Where(x => x.PhoneNumber.ToLower().Contains(filterModel.PhoneNumber.ToLower()));
            }
            if (!string.IsNullOrEmpty(filterModel.Address))
            {
                filter = filter.Where(x => x.Address.ToLower().Contains(filterModel.Address.ToLower()));
            }

            return filter;
        }
    }
}
