using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myuser.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myuser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {

        private readonly AppDBContext _dbContext;
        // IUser InjectDep = null;

        /*
                public UserController(IUser Iu)
                {
                    this.InjectDep = Iu;
                   // _dbContext = new AppContext();
                }
        */
        public PostController(AppDBContext dbContext)
        {
            this._dbContext = dbContext;
            // _dbContext = new AppContext();
        }

        [HttpGet]
        public IEnumerable<Post> getall()
        {
            return _dbContext.posts.ToList();

        }
        /*
        [HttpGet("{id}")]
        public Posts get(int id)
        {
            //  return _dbContext.users.SingleOrDefault(item => item.id == id);
            return _dbContext.users.SingleOrDefault(item => item.id == id);
            // return InjectDep.get(id)
;
            //  return us.SingleOrDefault(item => item.id == id);
        }
        */
        [HttpPost]
        public void addPost([FromBody] Post u)
        {
            _dbContext.posts.Add(u);
            _dbContext.SaveChanges();
            //InjectDep.addUser(u);
            //us.Add(u);
        }


    }

    /*  private static readonly string[] Summaries = new[]
      {
          "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
      };

      private readonly ILogger<PostController> _logger;

      public PostController(ILogger<PostController> logger)
      {
          _logger = logger;
      }

      [HttpGet]
      public IEnumerable<WeatherForecast> Get()
      {
          var rng = new Random();
          return Enumerable.Range(1, 5).Select(index => new WeatherForecast
          {
              Date = DateTime.Now.AddDays(index),
              TemperatureC = rng.Next(-20, 55),
              Summary = Summaries[rng.Next(Summaries.Length)]
          })
          .ToArray();
      }
  }
    */
}
















