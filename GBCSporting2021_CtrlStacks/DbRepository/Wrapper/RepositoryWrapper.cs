using GBCSporting2021_CtrlStacks.DbRepository.RepositoryCollection;
using GBCSporting2021_CtrlStacks.Models;

namespace GBCSporting2021_CtrlStacks.DbRepository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private SportsProContext _context;
        private ICustomerRepository _customer;
        private IIncidentRepository _incident;
        private IProductRepository _product;
        private IRegistrationRepository _registration;
        private ITechnicianRepository _technician;
        private ICountryRepository _country;

        public RepositoryWrapper(SportsProContext context)
        {
            _context = context;
        }

        public ICustomerRepository Customer
        {
            get {
                if (_customer == null) _customer = new CustomerRepository(_context);
                return _customer;
            }
        }
        public IIncidentRepository Incident
        {
            get
            {
                if (_incident == null) _incident = new IncidentRepository(_context);
                return _incident;
            }
        }
        public IProductRepository Product
        {
            get
            {
                if (_product == null) _product = new ProductRepository(_context);
                return _product;
            }
        }
        public IRegistrationRepository Registration
        {
            get
            {
                if (_registration == null) _registration = new RegistrationRepository(_context);
                return _registration;
            }
        }
        public ITechnicianRepository Technician
        {
            get
            {
                if (_technician == null) _technician = new TechnicianRepository(_context);
                return _technician;
            }
        }
        public ICountryRepository Country
        {
            get
            {
                if (_country == null) _country = new CountryRepository(_context);
                return _country;
            }
        }
    }
}
