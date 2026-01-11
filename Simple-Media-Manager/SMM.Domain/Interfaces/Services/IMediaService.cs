using SMM.Domain.DTOs.MediaDTOs;
using SMM.Domain.Entities;

namespace SMM.Domain.Interfaces.Services
{
    public interface IMediaService
    {
        Task<List<Media>> GetAll();
        Task<long> Add(MediaCreateDto dto);
        Task<Media> Delete(long id);
        Task<Media> GetById(long id);
        Task<Media> Put(long id, MediaPutDTO updatedEntity);
    }
}
