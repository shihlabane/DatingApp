using DatingApp.AppUser;
using DatingApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase //Derive from controller base
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        //Forgetting data  ...Using async  to have asychronouse method
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUsers>>> GetUsers()
        {

            return await _context.Users.ToListAsync();

      
        }
        //api/users/1 or 2
        [HttpGet("{id}")]//To get user by ID
        public async Task<ActionResult<AppUsers>> GetUser(int id)
        {
            return await  _context.Users.FindAsync(id);

           

        }

    }
}
 