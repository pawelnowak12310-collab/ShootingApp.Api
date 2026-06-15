using ShootingApp.Api.Models;

namespace ShootingApp.Api.Repositories
{
    public interface IShootingRepository
    {
        Task AddSessionAsync(ShootingSession session);
        Task ClearAllSessionsAsync();
        Task<List<ShootingSession>> GetAllAsync();
    }
}