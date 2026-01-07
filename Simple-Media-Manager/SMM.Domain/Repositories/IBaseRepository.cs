using SMM.Domain.Common;

namespace SMM.Domain.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetById(long id);
        Task<long> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(long id);
    }
}
