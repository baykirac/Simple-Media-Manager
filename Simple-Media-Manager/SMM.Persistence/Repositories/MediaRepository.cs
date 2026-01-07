using Microsoft.EntityFrameworkCore;
using SMM.Domain.Entities;
using SMM.Domain.Repositories;
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

        public async Task<List<Media>> GetAll()
        {
            return await context.Medias.ToListAsync();
        }

        public async Task<Media?> GetById(long id)
        {
            return await context.Medias.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Media> UpdateAsync(Media entity)
        {
            context.Medias.Update(entity);
            await context.SaveChangesAsync();

            return entity;
        }
    }
}
