using GBCSporting2021_CtrlStacks.Models;

namespace GBCSporting2021_CtrlStacks.DbRepository.RepositoryCollection
{
    public interface ICustomerRepository : IRepository<Customer>{}
    public interface IIncidentRepository : IRepository<Incident> { }
    public interface IProductRepository : IRepository<Product> { }
    public interface IRegistrationRepository : IRepository<Registration> { }
    public interface ITechnicianRepository : IRepository<Technician> { }
    public interface ICountryRepository : IRepository<Country> { }
}
