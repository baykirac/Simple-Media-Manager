using SMM.Domain.DTOs.MediaDTOs;
using SMM.Domain.Entities;

namespace SMM.Domain.Interfaces.Services
{
    public interface IMediaService
    {
        Task<List<Media>> GetAllAsync();
        Task<long> AddAsync(MediaCreateDto dto);
        Task<Media> DeleteAsync(long id);
        Task<Media> GetByIdAsync(long id);
        Task<Media> UpdateAsync(long id, MediaPutDTO updatedEntity);
    }
}
