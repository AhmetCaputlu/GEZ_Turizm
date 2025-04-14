using DataAccess.Context;
using DataAccess.Entities.Enums;
using DataAccess.Entities.Models.Employees;
using DataAccess.Repositories.Abstracts.Employee;
using DataAccess.Repositories.Abstracts.EmployeeR;
using DataAccess.Repositories.Concretes.Employee;

namespace DataAccess.Repositories.Concretes.EmployeeR
{
    public class TourGuideRepository : GenericEmployeeRepository<ContractTourGuide>, IGenericEmployeeRepository<ContractTourGuide>, ITourGuideRepository
    {
        private readonly GezTurizmContext _context;

        public TourGuideRepository(GezTurizmContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<ContractTourGuide> GetTourGuidesByLanguage(Language language)
        {
            return _context.ContractTourGuides.Where(x => x.Language == language);
        }
    }
}
