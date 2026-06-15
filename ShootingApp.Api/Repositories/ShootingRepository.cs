using Microsoft.EntityFrameworkCore;
using ShootingApp.Api.Data;
using ShootingApp.Api.Models;

namespace ShootingApp.Api.Repositories
{
    public class ShootingRepository : IShootingRepository
    {
        private readonly AppDbContext _context;

        public ShootingRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddSessionAsync(ShootingSession session)
        {
            _context.Sessions.Add(session);
            await _context.SaveChangesAsync();
        }

        public async Task ClearAllSessionsAsync()
        {
            _context.Sessions.RemoveRange(_context.Sessions);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ShootingSession>> GetAllAsync()
        {
            return await _context.Sessions.ToListAsync();
        }
    }
}