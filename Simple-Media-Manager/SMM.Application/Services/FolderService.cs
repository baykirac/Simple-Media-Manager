using SMM.Domain.Entities;
using SMM.Domain.Interfaces.Repositories;

namespace SMM.Application.Services
{
    public class FolderService
    {
        private readonly IFolderRepository fodlerRepository;

        public FolderService(IFolderRepository fodlerRepository)
        {
            this.fodlerRepository = fodlerRepository;
        }

        public async Task<List<Folder>> GetAll()
        {
            return await fodlerRepository.GetAllAsync();
        }
    }
}
