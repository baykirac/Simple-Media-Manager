using SMM.Domain.Common;
using SMM.Domain.Entities;

namespace SMM.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(long id);
        Task<long> CreateAsync(T entity);
        Task<T> DeleteAsync(long id);
    }
}
