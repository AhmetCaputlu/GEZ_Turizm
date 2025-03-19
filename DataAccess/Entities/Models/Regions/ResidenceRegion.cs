using DataAccess.Entities.Abstracts;
using DataAccess.Entities.Models.Employees;

namespace DataAccess.Entities.Models.Regions
{
    public class ResidenceRegion:BaseRegionModel
    {
        //Mapping
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
