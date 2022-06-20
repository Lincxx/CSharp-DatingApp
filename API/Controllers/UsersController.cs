using System;
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
  
  public class UsersController : BaseApiController
  {
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
      _context = context;
    }

    // endpoints
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        return await _context.Users.ToListAsync();
        
    }
    // this is sync
    // public ActionResult<IEnumerable<AppUser>> GetUsers()
    // {
    //     return _context.Users.ToList();
        
    // }

    [Authorize]
    // api/users/3
    [HttpGet("{id}")] // get by Id
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    // public ActionResult<AppUser> GetUser(int id)
    // {
    //     return  _context.Users.Find(id);
    // }
  }
}