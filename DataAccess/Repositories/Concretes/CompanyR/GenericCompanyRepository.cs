using Azure.Core;
using DataAccess.Context;
using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Enums;
using DataAccess.Repositories.Abstracts.Company;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concretes.Company
{
    public class GenericCompanyRepository<T> : GenericRepository<T>, IGenericCompanyRepository<T> where T : BaseCompanyModel
    {
        private readonly GezTurizmContext _context;
        private readonly DbSet<T> _dbset;
        public GenericCompanyRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }
        public IQueryable<T> SearchByCompanyName(string companyName)
        {
            var selectedItems = _dbset.Where(x => x.CompanyName.ToLower().Contains(companyName.ToLower()));
            return selectedItems;
        }
        public IQueryable<T> SearchByContactName(string contactName)
        {
            var selectedItems = _dbset.Where(x => x.ContactName.ToLower().Contains(contactName.ToLower()));
            return selectedItems;
        }
        public IQueryable<T> SearchByContactTitle(string contactTitle)
        {
            var selectedItems = _dbset.Where(x => x.ContactTitle.ToLower().Contains(contactTitle.ToLower()));
            return selectedItems;
        }
        public IQueryable<T> SearchByEmail(string email)
        {
            var selectedItems = _dbset.Where(x => x.Email.ToLower().Contains(email.ToLower()));
            return selectedItems;
        }
        public IQueryable<T> SearchByPhoneNumber(string phoneNumber)
        {
            var selectedItems = _dbset.Where(x => x.PhoneNumber.ToLower().Contains(phoneNumber.ToLower()));
            return selectedItems;
        }
        public IQueryable<T> SearchByAdress(string address)
        {
            var selectedItems = _dbset.Where(x => x.Address.ToLower().Contains(address.ToLower()));
            return selectedItems;
        }
    }
}
