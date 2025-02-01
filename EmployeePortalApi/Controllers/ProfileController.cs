using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeePortalApi.Data;
using EmployeePortalApi.Entities;
using EmployeePortalApi.DTOs;

namespace EmployeePortalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProfileController(AppDbContext appDbContext)
        {
            _context = appDbContext;

        }
        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<List<ProfileDTO>>> GetProfiles()
        {
            var profiles = await _context.Profiles.ToListAsync();
            var profilesDTO = profiles.Select(profile => new ProfileDTO
            {
                IdProfile = profile.IdProfile,
                Name = profile.Name
            }).ToList();
            return profilesDTO;
        }
    }
}
