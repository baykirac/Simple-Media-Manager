using SMM.Domain.DTOs.FolderDTOs;
using SMM.Domain.Entities;
using SMM.Domain.Interfaces.Repositories;
using SMM.Domain.Interfaces.Services;

namespace SMM.Application.Services
{
    public class FolderService : IFolderService
    {
        private readonly IFolderRepository folderRepository;

        public FolderService(IFolderRepository fodlerRepository)
        {
            this.folderRepository = fodlerRepository;
        }
        public async Task<List<Folder>> GetAllAsync()
        {
            return await folderRepository.GetAllAsync();
        }

        public async Task<long> AddAsync(FolderCreateDTO dto)
        {
            var folder = Folder.Create(dto.FolderName, dto.ParentId);

            return await folderRepository.CreateAsync(folder);
        }

        public async Task<Folder?> DeleteAsync(long id)
        {
            return await folderRepository.DeleteAsync(id);
        }

        public async Task<Folder?> GeyByIdAsync(long id)
        {
            return await folderRepository.GetByIdAsync(id);
        }

        public async Task<Folder?> UpdateAsync(long id, FolderPutDTO dto)
        {
            return await folderRepository.UpdateAsync(id, dto);
        }
    }
}