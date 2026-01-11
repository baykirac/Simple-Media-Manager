using SMM.Domain.DTOs.FolderDTOs;
using SMM.Domain.Entities;

namespace SMM.Domain.Interfaces.Services
{
    public interface IFolderService
    {
        Task<List<Folder>> GetAllAsync();
        Task<long> AddAsync(FolderCreateDTO dto);
        Task<Folder> DeleteAsync(long id);
        Task<Folder> GeyByIdAsync(long id);
        Task<Folder> UpdateAsync(long id, FolderPutDTO dto);
    }
}
