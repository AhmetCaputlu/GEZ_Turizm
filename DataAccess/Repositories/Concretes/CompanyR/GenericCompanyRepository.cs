using System;
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

        public IQueryable<T> GetDynamicCompanyFilter(string? companyName = null, string? contactName = null, string? contactTitle = null, string? email = null, string? phoneNumber = null, string? address = null,
            bool? descending = null)
        {
            IQueryable<T> filter = _dbset;

            if (!string.IsNullOrEmpty(companyName))
            {
                filter = filter.Where(x => x.CompanyName.ToLower().Contains(companyName.ToLower()));
            }
            if (!string.IsNullOrEmpty(contactName))
            {
                filter = filter.Where(x => x.ContactName.ToLower().Contains(contactName.ToLower()));
            }
            if (!string.IsNullOrEmpty(contactTitle))
            {
                filter = filter.Where(x => x.ContactName.ToLower().Contains(contactTitle.ToLower()));
            }
            if (!string.IsNullOrEmpty(email))
            {
                filter = filter.Where(x => x.Email.ToLower().Contains(email.ToLower()));
            }
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                filter = filter.Where(x => x.PhoneNumber.ToLower().Contains(phoneNumber.ToLower()));
            }
            if (!string.IsNullOrEmpty(address))
            {
                filter = filter.Where(x => x.Address.ToLower().Contains(address.ToLower()));
            }
            if (descending == true)
            {
                filter = filter.OrderByDescending(x => x.Id);
            }

            return filter;
        }
    }
}
