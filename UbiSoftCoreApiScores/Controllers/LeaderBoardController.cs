using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UbiSoftCoreApiScores.Data;
using UbiSoftCoreApiScores.Models;

namespace UbiSoftCoreApiScores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaderBoardController : ControllerBase
    {
        private readonly ServiceContext _serviceContext;

        public LeaderBoardController(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }


        // GET: api/LeaderBoard
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _serviceContext.users.ToArray();

        }

        // GET: api/LeaderBoard/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return _serviceContext.users.FirstOrDefault(e => e.Id == id);
        }

        [HttpGet("{match}", Name = "GetbyMatch")]
        [Route("api/{LeaderBoard}/{id?}/{match}")]
        public User GetbyMatch(string match)
        {
            return _serviceContext.users.FirstOrDefault(e => e.Match == match);
        }

        // POST: api/LeaderBoard
        [HttpPost]
        public async Task<ActionResult<IEnumerable<User>>> Post(User value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _serviceContext.users.Add(value);
            await _serviceContext.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = value }, value);

        }

        // PUT: api/LeaderBoard/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
