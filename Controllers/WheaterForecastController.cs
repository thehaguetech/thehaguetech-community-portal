using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using thehaguetech_community_portal.Models;

[ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private IList<WeatherForecast> cities = new List<WeatherForecast>();
        // private readonly IList<GameState> _games = new List<GameState>();

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        // public ActionResult<IEnumerable<GameState>> LoadGame()

        public ActionResult<IEnumerable<WeatherForecast>> Get(String id)
        {

            
            System.Console.WriteLine(id);
            var rng = new Random();

                 WeatherForecast a = new WeatherForecast(){
            Date = DateTime.Now.AddDays(1),
            TemperatureC = rng.Next(-20, 55),
            Summary = "test" + rng.Next(-20, 55)
        };
           WeatherForecast b = new WeatherForecast(){
            Date = DateTime.Now.AddDays(1),
            TemperatureC = rng.Next(-20, 55),
            Summary = "test" + rng.Next(-20, 55)
        };

        this.cities.Add(a);
        this.cities.Add(b);
        
        // return Ok(this.cities);
        System.Console.WriteLine(this.cities);



            if(id == "101"){
                return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .ToArray();
            }
                        
        


                    if(id == "100"){

        return Ok(this.cities);
                    }

        return new NotFoundResult();



            //    return Enumerable.Range(1, 2).Select(index => new WeatherForecast
            //     {
            //         Date = DateTime.Now.AddDays(index),
            //         TemperatureC = rng.Next(-20, 55),
            //         Summary = Summaries[rng.Next(Summaries.Length)]
            //     })
            //     .ToArray();
        }



      [HttpGet]
        // public ActionResult<IEnumerable<GameState>> LoadGame()
        public ActionResult<Profile> GetAll()
        {
     
                    using (var db = new PortalContext())
            {
                // Create
                // Console.WriteLine("Inserting a new blog");
                // db.Add(new Profile { 
                //     firstName = "Jan",
                //     lastName = "Piet",
                //     email = "JanPiet",
                //     socialLinks = "FB",
                //     memberSince = 2016,
                //     expertise = "C#",
                //     picture= "none"

                //  });
                // db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a blog");
                var blog = db.profiles
                    .OrderBy(b => b.profileID)
                    .First();




                return blog;
            }
        }


            
            [HttpPost]
        public ActionResult createNewInstance()
        {
            var rng = new Random();

        WeatherForecast a = new WeatherForecast(){
            Date = DateTime.Now.AddDays(1),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        };
           WeatherForecast b = new WeatherForecast(){
            Date = DateTime.Now.AddDays(1),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        };

        this.cities.Append(a);
        this.cities.Append(b);


        return Ok(this.cities);
        }
}
