using HotelListingApi.Data;
using HotelListingApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly HotelListingDbContext _ctx;

        public GenericRepository(HotelListingDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _ctx.AddAsync(entity);
            await _ctx.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            _ctx.Set<T>().Remove(entity);
            await _ctx.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _ctx.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int? id)
        {
            if (id is null) return null;
            return await _ctx.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _ctx.Update(entity);
            await _ctx.SaveChangesAsync(); 
        }
    }
}
