using Microsoft.EntityFrameworkCore;
using SMM.Domain.Entities;
using SMM.Domain.Interfaces.Repositories;
using SMM.Persistence.Context;

namespace SMM.Persistence.Repositories
{
    public class FolderRepository : IFolderRepository
    {
        private readonly MediaManagerDbContext context;

        public FolderRepository(MediaManagerDbContext context)
        {
            this.context = context;
        }

        public async Task<long> CreateAsync(Folder entity)
        {
            await context.Folders.AddAsync(entity);
            await context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<Folder?> DeleteAsync(long id)
        {
            var entity = await context.Folders.FindAsync(id);

            if (entity == null)
                return null;

            context.Folders.Remove(entity);

            return entity;
        }

        public async Task<List<Folder>> GetAllAsync()
        {
            return await context.Folders.ToListAsync();
        }

        public async Task<Folder?> GetByIdAsync(long id)
        {
            return await context.Folders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Media> UpdateAsync(long id, Folder updatedEntity)
        {
            throw new NotImplementedException();
        }
    }
}
