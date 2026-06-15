using Microsoft.AspNetCore.Mvc;
using ShootingApp.Api.Data;
using ShootingApp.Api.Models;
using ShootingApp.Api.Repositories;

namespace ShootingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShootingSessionsController : ControllerBase
    {
        private readonly IShootingRepository _repository;

        public ShootingSessionsController(IShootingRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> SaveSession([FromBody] ShootingSession session)
        {
            await _repository.AddSessionAsync(session);
            return Ok();
        }

        [HttpDelete("clear")]
        public async Task<IActionResult> ClearSessions()
        {
            await _repository.ClearAllSessionsAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var sessions = await _repository.GetAllAsync();
            return Ok(sessions);
        }
    }
}