using SMM.Domain.DTOs.MediaDTOs;
using SMM.Domain.Entities;

namespace SMM.Domain.Interfaces.Repositories
{
    public interface IMediaRepository : IBaseRepository<Media>
    {
        Task<Media> UpdateAsync(long id, MediaPutDTO updatedEntity);
    }
}
