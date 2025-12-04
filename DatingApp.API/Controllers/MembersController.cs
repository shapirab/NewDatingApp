using DatingApp.DATA.Models.Entities;
using DatingApp.DATA.Services.Implementations.SQL;
using DatingApp.DATA.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController(IMemberService memberService) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetMembers()
        {
            IEnumerable<AppUser> users = await memberService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetMember(string id)
        {
            AppUser? user = await memberService.GetUser(id);
            if(user == null)
            {
                return NotFound("User with this id was not found");
            }
            return Ok(user);
        }
    }
}
