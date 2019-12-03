using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using thehaguetech_community_portal.Models;


[ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        static HttpClient client = new HttpClient();

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


        private static async Task<string> RequestTokenToAuthorizationServer(Uri uriAuthorizationServer, string clientId, string scope, string clientSecret)
        {
            HttpResponseMessage responseMessage;
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage tokenRequest = new HttpRequestMessage(HttpMethod.Post, uriAuthorizationServer);
                HttpContent httpContent = new FormUrlEncodedContent(
                    new[]
                    {
                    new KeyValuePair<string, string>("grant_type", "client_credentials"),
                    new KeyValuePair<string, string>("client_id", clientId),
                    new KeyValuePair<string, string>("scope", scope),
                    new KeyValuePair<string, string>("client_secret", clientSecret)
                    });
                tokenRequest.Content = httpContent;
                responseMessage = await client.SendAsync(tokenRequest);
            }
            return await responseMessage.Content.ReadAsStringAsync();
        }


      [HttpGet]
        // public ActionResult<IEnumerable<GameState>> LoadGame()
        public  ActionResult<IEnumerable<WeatherForecast>> GetAllAsync()
        {


            Uri authorizationServerTokenIssuerUri = new Uri("https://identity.officernd.com/oauth/token");
            string clientId = "y8lP1LZNSQyzcGys";    
            string clientSecret = "whasbS3xxik2G1a94ZmsrLXZyfLUIkIH";
            string scope = "officernd.api.read";

            //access token request
            string rawJwtToken = RequestTokenToAuthorizationServer(
                 authorizationServerTokenIssuerUri,
                 clientId, 
                 scope, 
                 clientSecret)
                .GetAwaiter()
                .GetResult();



            System.Console.WriteLine(rawJwtToken);

        // var request = new HttpRequestMessage(HttpMethod.Post, "https://identity.officernd.com/oauth/token");
        // request.Content = new FormUrlEncodedContent(new Dictionary<string, string> {
        //     { "client_id", "y8lP1LZNSQyzcGys" },
        //     { "client_secret", "whasbS3xxik2G1a94ZmsrLXZyfLUIkIH" },
        //     { "grant_type", "client_credentials" }
        // });
        
            // var client = new HttpClient
            // {
            //     BaseAddress = new Uri("https://identity.officernd.com/oauth/token")
            // };


            // var content = new StringContent(
            //     JsonConvert.SerializeObject(
            //         new 
            //         { 
            //             client_id = "y8lP1LZNSQyzcGys", 
            //             client_secret = "whasbS3xxik2G1a94ZmsrLXZyfLUIkIH", 
            //             grant_type = "client_credentials" 
            //         }), Encoding.UTF8, "application/json"); 
                    
            //                        System.Console.WriteLine(content);

            // var response = await client.PostAsync("oauth/token", content); 
            // var tokenResponse = await response.Content.ReadAsStringAsync();


            // System.Console.WriteLine(response);
            // System.Console.WriteLine(tokenResponse);



    // var request = new HttpRequestMessage(HttpMethod.Post, "https://identity.officernd.com/oauth/token");
    // request.Content = new FormUrlEncodedContent(new Dictionary<string, string> {
    //     { "client_id", "y8lP1LZNSQyzcGys" },
    //     { "client_secret", "whasbS3xxik2G1a94ZmsrLXZyfLUIkIH" },
    //     { "grant_type", "client_credentials" }
    // });
    // System.Console.WriteLine(request.Content);
    // var response = await client.SendAsync(request);
    // response.EnsureSuccessStatusCode();
    // System.Console.WriteLine(response);


    // var payload = JObject.Parse(await response.Content.ReadAsStringAsync());
    // var token = payload.Value<string>("access_token");


                        var rng = new Random();


                        
           return Enumerable.Range(1, 2).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .ToArray();
            
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
