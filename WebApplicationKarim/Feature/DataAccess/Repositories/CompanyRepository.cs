using WebApplicationKarim.Feature.DomainModel;

namespace WebApplicationKarim.Feature.DataAccess.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(KarimDbContext context):base(context)
        {
            
        }
    }
}
