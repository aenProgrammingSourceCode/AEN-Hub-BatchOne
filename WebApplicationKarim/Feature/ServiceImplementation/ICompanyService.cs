using WebApplicationKarim.Feature.Messaging;

namespace WebApplicationKarim.Feature.ServiceImplementation
{
    public interface ICompanyService
    {
        Task Add(AddCompanyRequest request);

    }
}
