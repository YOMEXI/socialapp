using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace api.Controllers
{
    public class PostController : BaseApiController
    {
        public readonly DataContext _context;
        public PostController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Post>>> GetAllPost()
        {
            return await _context.Posts.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Post>> GetOnePost(Guid id)
        {
            return await _context.Posts.FindAsync(id);
        }
    }
}