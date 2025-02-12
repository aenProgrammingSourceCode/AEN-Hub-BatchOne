namespace WebApplicationKarim.Feature.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        Task Add(T entity);
    }
}
