using SMM.Domain.DTOs.MediaDTOs;
using SMM.Domain.Entities;
using SMM.Domain.Interfaces.Repositories;
using SMM.Domain.Interfaces.Services;

namespace SMM.Application.Services
{
    public class MediaService : IMediaService
    {
        private readonly IMediaRepository mediaRepository;

        public MediaService(IMediaRepository mediaRepository)
        {
            this.mediaRepository = mediaRepository;
        }

        public async Task<List<Media>> GetAll()
        {
            return await mediaRepository.GetAllAsync();
        }

        public async Task<long> Add(MediaCreateDto dto)
        {
            var media = Media.Create(dto.MediaName, dto.MediaUrl, dto.FolderId);

            return await mediaRepository.CreateAsync(media);
        }

        public async Task<Media> Delete(long id)
        {
            return await mediaRepository.DeleteAsync(id);
        }

        public async Task<Media> GetById(long id)
        {
            return await mediaRepository.GetByIdAsync(id);
        }

        public async Task<Media> Put(long id, MediaPutDTO updatedEntity)
        {
            return await mediaRepository.UpdateAsync(id, updatedEntity);
        }
    }
}
