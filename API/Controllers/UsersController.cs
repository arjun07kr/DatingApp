using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _db;
        public UsersController(DataContext db)
        {
            _db =db;
        }
        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUser()
        {
            var users = _db.Users.ToList();
            return users;
        }
        [HttpGet("{id}")]
        
        public ActionResult<AppUser> GetUser(int id)
        {
            var users = _db.Users.Find(id);
            return users;
        }
    }
}