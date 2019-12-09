using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace thehaguetech_community_portal.Models
{ 
    public class Apicontroller
    {
        public static JObject JWTtoken {set; get;}
        // private string apiBaseURL = "https://app.officernd.com/api/v1/organizations/thehaguetech/resources";

    private static async Task<string> RequestTokenToAuthorizationServer(Uri uriAuthorizationServer, string clientId, string scope, string clientSecret){
            HttpResponseMessage responseMessage;
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage tokenRequest = new HttpRequestMessage(HttpMethod.Post, uriAuthorizationServer);
                HttpContent httpContent = new FormUrlEncodedContent(
                    new[]
                    {
                    new KeyValuePair<string, string>("content-Type", "application/x-www-form-urlencoded"),
                    new KeyValuePair<string, string>("grant_type", "client_credentials"),
                    new KeyValuePair<string, string>("client_id", clientId),
                    new KeyValuePair<string, string>("scope", scope),
                    new KeyValuePair<string, string>("client_secret", clientSecret)
                    });
                tokenRequest.Content = httpContent;
                
                responseMessage = await client.SendAsync(tokenRequest);
            }

            return await (responseMessage.Content.ReadAsStringAsync());
        }

        public static void GetAuthorisationToken()
        {
            Uri authorizationServerTokenIssuerUri = new Uri("https://identity.officernd.com/oauth/token");
            string clientId = "y8lP1LZNSQyzcGys"; 
            string clientSecret = "whasbS3xxik2G1a94ZmsrLXZyfLUIkIH";
            string scope = "officernd.api.write officernd.api.read";

            System.Console.WriteLine(authorizationServerTokenIssuerUri);


            //access token request
            string rawJwtToken = RequestTokenToAuthorizationServer(
                 authorizationServerTokenIssuerUri,
                 clientId,
                 scope,
                 clientSecret)
                .GetAwaiter()
                .GetResult();
                
            JObject jToken = JObject.Parse(rawJwtToken);
            Apicontroller.JWTtoken =  jToken;
            System.Console.Write(Apicontroller.JWTtoken);
        }

    public static async Task<JArray> requestHttp (string ApiCallUrl){
            var request = new HttpRequestMessage(HttpMethod.Get, ApiCallUrl);

            request.Headers.Add("Authorization", "Bearer " + Apicontroller.JWTtoken.GetValue("access_token"));
            var client = new HttpClient();
            
            var response = await client.SendAsync(request);
            Console.WriteLine(response.Content);

            string responseMessage = await response.Content.ReadAsStringAsync();

            JArray jsonArray = JArray.Parse(responseMessage);
        
            if (response.IsSuccessStatusCode){
                return jsonArray;
            }

            return null;
    }



    public static async Task<IList<Company>> getAllCompanies(){
        System.Console.WriteLine(Apicontroller.JWTtoken);
        string apiUrl = "https://app.officernd.com/api/v1/organizations/thehaguetech/teams";
       
        JArray responseMessage = await requestHttp(apiUrl);
       
        if(responseMessage != null){
        IList<Company> companies = new List<Company>();

        foreach(JObject Jcompany  in responseMessage){
            // Console.WriteLine(Jcompany.GetValue("email"));
            Company _company =  new Company();

            // _company.profileID = Jcompany.GetValue("_id").ToString();
            System.Console.WriteLine(Jcompany.GetValue("name").ToString());
            // _company.email = Jcompany.GetValue("email").ToString();
            // _company.picture = Jcompany.GetValue("image").ToString();
            // _company.memberSince = DateTime.Parse(Jcompany.GetValue("startDate").ToString());


            _company.comapnyName = Jcompany.GetValue("name").ToString();
            // _company.companyWebsite = Jcompany.GetValue("url").ToString();
            // _company.companyAddress = Jcompany.GetValue("address").ToString();
            // _company.companyType = Jcompany.GetValue("description").ToString();

            companies.Add(_company);
            }  

            System.Console.WriteLine(companies);
            return companies;
        }
        return new List<Company>();
    }

    public static async Task getAllMembersAsync(){
        System.Console.WriteLine(Apicontroller.JWTtoken);
        string apiUrl = "https://app.officernd.com/api/v1/organizations/thehaguetech/members";
        JArray responseMessage = await requestHttp(apiUrl);
        
        foreach(JObject jsobj  in responseMessage){
            Console.WriteLine(jsobj.GetValue("email"));
            }  
    }

    // public static void get
    //         public  async Task OnGet(String rawJwtToken)
    //     {
    //         var token = rawJwtToken.Split(":")[1].Split(",")[0].ToString();
           
           
    //         JObject jToken = JObject.Parse(rawJwtToken);
    //         System.Console.WriteLine(jToken);
    //         System.Console.WriteLine(jToken.GetValue("access_token"));

    //         var request = new HttpRequestMessage(HttpMethod.Get, 
    //         // "https://app.officernd.com/api/v1/organizations/thehaguetech/resources");

    //         "https://app.officernd.com/api/v1/organizations/thehaguetech/members");
    //         // request.Headers.Add("Accept", "application/vnd.github.v3+json");
    //         // request.Headers.Add("Authorization", "Bearer " + token);

    //         request.Headers.Add("Authorization", "Bearer " + jToken.GetValue("access_token"));
    //         // System.Console.WriteLine(Apicontroller.token);
    //         // Apicontroller.token = token;
    //         // System.Console.WriteLine(Apicontroller.token);


    //         var client = new HttpClient();
    //         System.Console.WriteLine(request);

    //         System.Console.WriteLine(token);

    //         var response = await client.SendAsync(request);
    //        Console.WriteLine(response.Content);
    //         if (response.IsSuccessStatusCode)
    //         {

    //             String responseMessage;
    //             responseMessage = await response.Content.ReadAsStringAsync();
    //             System.Console.WriteLine(responseMessage);

    //             JArray jsonArray = JArray.Parse(responseMessage);

    //             System.Console.WriteLine(jsonArray.Count());
    //             JArray jArray = JArray.Parse(responseMessage);
    //             System.Console.WriteLine(jArray);
    //             // var dict = JsonConvert.DeserializeObject<Members>(responseMessage);
    //             // Console.WriteLine(dict);
    //             foreach(JObject jsobj  in jArray){
    //                 Console.WriteLine(jsobj.GetValue("email"));
    //             }  
    //         }
    //         else
    //         {

    //         }
    //     }




    }
}