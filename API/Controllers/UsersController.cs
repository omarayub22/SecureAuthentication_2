using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    /*[ApiController]
    [Route("api/[controller]")]*/  // noloinger need because of inheritance
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        /*public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = _context.Users.ToList();
            return users;

        }*/
           public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
           return await _context.Users.ToListAsync();
        }
// api/users/3
        [Authorize]
        [HttpGet("{id}")]
         public async Task<ActionResult<AppUser>> GetUser(int id)
        {
        return await _context.Users.FindAsync(id);
        }
    }
}

// for scalibilty