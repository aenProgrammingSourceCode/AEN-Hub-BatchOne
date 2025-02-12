
using WebApplicationKarim.Feature.DataAccess.Repositories;
using WebApplicationKarim.Feature.DomainModel;
using WebApplicationKarim.Feature.Messaging;

namespace WebApplicationKarim.Feature.ServiceImplementation
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public async Task Add(AddCompanyRequest request)
        {
            Company company = new()
            {
                Name = request.Name
            };

            await _companyRepository.Add(company);
        }
    }
}
