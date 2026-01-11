using AutoMapper;
using SMM.Domain.DTOs.FolderDTOs;
using SMM.Domain.DTOs.MediaDTOs;
using SMM.Domain.Entities;

namespace SMM.Domain.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Media, MediaCreateDto>();
            CreateMap<Media, MediaPutDTO>();

            CreateMap<Folder, FolderCreateDTO>();
            CreateMap<Folder, FolderPutDTO>();
        }
    }
}
