using AutoMapper;
using SMM.Domain.DTOs.MediaDTOs;
using SMM.Domain.Entities;

namespace SMM.Domain.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Media, MediaCreateDto>();
        }
    }
}
