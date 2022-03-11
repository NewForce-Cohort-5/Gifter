using System;
using Microsoft.AspNetCore.Mvc;
using Gifter.Repositories;
using Gifter.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gifter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileRepository _userProfileRepository;
        public UserProfileController(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userProfileRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var post = _userProfileRepository.GetById(id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [HttpGet("GetPostsbyUser")]
        public IActionResult GetPostsbyUser(int id)
        {
            var users = _userProfileRepository.GetPostsByUser(id);
            return Ok(users);
        }

       

        [HttpPost]
        public IActionResult Post(UserProfile user)
        {
            _userProfileRepository.Add(user);
            return CreatedAtAction("Get", new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UserProfile user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _userProfileRepository.Update(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userProfileRepository.Delete(id);
            return NoContent();
        }
    }
}
