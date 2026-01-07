using SMM.Domain.DTOs.MediaDTOs;
using SMM.Domain.Entities;
using SMM.Domain.Repositories;

namespace SMM.Application.Services
{
    public class MediaService
    {
        private readonly IMediaRepository mediaRepository;

        public MediaService(IMediaRepository mediaRepository)
        {
            this.mediaRepository = mediaRepository;
        }

        public async Task<List<Media>> GetAll()
        {
            return await mediaRepository.GetAll();
        }

        public async Task<long> Add(MediaCreateDto dto)
        {
            var media = Media.Create(dto.MediaName, dto.MediaUrl, dto.FolderId);

            return await mediaRepository.CreateAsync(media);
        }
    }
}
