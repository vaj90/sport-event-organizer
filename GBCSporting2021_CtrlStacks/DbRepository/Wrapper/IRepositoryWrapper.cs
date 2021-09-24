using GBCSporting2021_CtrlStacks.DbRepository.RepositoryCollection;

namespace GBCSporting2021_CtrlStacks.DbRepository
{
    public interface IRepositoryWrapper
    {
        ICustomerRepository Customer { get; }
        IIncidentRepository Incident { get; }
        IProductRepository Product { get; }
        IRegistrationRepository Registration { get; }
        ITechnicianRepository Technician { get; }
        ICountryRepository Country { get; }
    }
}
