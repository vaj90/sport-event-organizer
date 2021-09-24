using GBCSporting2021_CtrlStacks.Models;

namespace GBCSporting2021_CtrlStacks.DbRepository.RepositoryCollection
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SportsProContext context) : base(context){}
    }

    public class IncidentRepository : Repository<Incident>, IIncidentRepository
    {
        public IncidentRepository(SportsProContext context) : base(context) { }
    }

    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(SportsProContext context) : base(context) { }
    }

    public class RegistrationRepository : Repository<Registration>, IRegistrationRepository
    {
        public RegistrationRepository(SportsProContext context) : base(context) { }
    }

    public class TechnicianRepository : Repository<Technician>, ITechnicianRepository
    {
        public TechnicianRepository(SportsProContext context) : base(context) { }
    }

    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(SportsProContext context) : base(context) { }
    }
}
