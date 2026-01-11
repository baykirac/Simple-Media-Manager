using Microsoft.EntityFrameworkCore;
using SMM.Domain.DTOs.MediaDTOs;
using SMM.Domain.Entities;
using SMM.Domain.Interfaces.Repositories;
using SMM.Persistence.Context;

namespace SMM.Persistence.Repositories
{
    public class MediaRepository : IMediaRepository
    {
        private readonly MediaManagerDbContext context;

        public MediaRepository(MediaManagerDbContext context)
        {
            this.context = context;
        }

        public async Task<long> CreateAsync(Media entity)
        {
            await context.Medias.AddAsync(entity);
            await context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<Media?> DeleteAsync(long id)
        {
            var entity = await context.Medias.FindAsync(id);
            if (entity == null)
                return null;

            context.Medias.Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<List<Media>> GetAllAsync()
        {
            return await context.Medias.ToListAsync();
        }

        public async Task<Media?> GetByIdAsync(long id)
        {
            return await context.Medias.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Media?> UpdateAsync(long id, MediaPutDTO updatedEntity)
        {
            var existingEntity = await context.Medias
                .FirstOrDefaultAsync(x => x.Id == id);

            if (existingEntity != null)
            {
                existingEntity.SetMediaUrl(updatedEntity.MediaUrl);
                existingEntity.SetMediaName(updatedEntity.MediaName);
                existingEntity.SetFolderId(updatedEntity.FolderId);
            }

            await context.SaveChangesAsync();

            return existingEntity;
        }
    }
}
