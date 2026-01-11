using SMM.Domain.DTOs.FolderDTOs;
using SMM.Domain.Entities;

namespace SMM.Domain.Interfaces.Repositories
{
    public interface IFolderRepository : IBaseRepository<Folder>
    {
        Task<Folder> UpdateAsync(long id, FolderPutDTO dto);
    }
}
