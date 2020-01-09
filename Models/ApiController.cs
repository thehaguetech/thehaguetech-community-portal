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
            // System.Console.Write(Apicontroller.JWTtoken);
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



    private static IList<string> validateKeyValues(IList<string> keys, JObject jsonObject){
        IList<string> validatedKeys = new List<string>();
        foreach(string key in keys){
            if(jsonObject.ContainsKey(key)){
                validatedKeys.Add(key);
            }
        }
        return validatedKeys;
    } 



     public static async Task<IList<Company>> getCompany(string id){
        string apiUrl = "https://app.officernd.com/api/v1/organizations/thehaguetech/teams?_id=" + id;
       
        JArray responseMessage = await requestHttp(apiUrl);
       
        if(responseMessage != null){
        IList<Company> companies = new List<Company>();

        foreach(JObject Jcompany  in responseMessage){
            Company _company =  new Company();
            string[] array = { "_id", "email", "image", "name", "url","address", "description","startDate"};
            IList<string> validatedKeys = validateKeyValues(array, Jcompany);
            
            foreach(string key in validatedKeys){
                switch(key){
                    case "_id": 
                        _company.profileID = Jcompany.GetValue(key).ToString();
                    break;
                    case "email": 
                        _company.email = Jcompany.GetValue(key).ToString();
                    break;
                    case "image": 
                        _company.picture = Jcompany.GetValue(key).ToString();
                    break;
                    case "name": 
                        _company.comapnyName = Jcompany.GetValue(key).ToString();
                    break;
                    case "url": 
                        _company.companyWebsite = Jcompany.GetValue(key).ToString();
                    break;
                    case "address": 
                        _company.companyAddress = Jcompany.GetValue(key).ToString();
                    break;
                    case "description": 
                        _company.description = Jcompany.GetValue(key).ToString();
                    break;
                    case "startDate":
                        _company.memberSince = DateTime.Parse(Jcompany.GetValue(key).ToString());
                    break;
                    default:
                    break;
                }
            }

            companies.Add(_company);
            }  

            System.Console.WriteLine(companies);
            return companies;
        }
        return new List<Company>();
    }






    public static async Task<IList<Company>> getAllCompanies(){
        System.Console.WriteLine(Apicontroller.JWTtoken);
        string apiUrl = "https://app.officernd.com/api/v1/organizations/thehaguetech/teams";
       
        JArray responseMessage = await requestHttp(apiUrl);
       
        if(responseMessage != null){
        IList<Company> companies = new List<Company>();

        foreach(JObject Jcompany  in responseMessage){
            Company _company =  new Company();
            string[] array = { "_id", "email", "image", "name", "url","address", "description","startDate"};
            IList<string> validatedKeys = validateKeyValues(array, Jcompany);
            
            foreach(string key in validatedKeys){
                switch(key){
                    case "_id": 
                        _company.profileID = Jcompany.GetValue(key).ToString();
                    break;
                    case "email": 
                        _company.email = Jcompany.GetValue(key).ToString();
                    break;
                    case "image": 
                        _company.picture = Jcompany.GetValue(key).ToString();
                    break;
                    case "name": 
                        _company.comapnyName = Jcompany.GetValue(key).ToString();
                    break;
                    case "url": 
                        _company.companyWebsite = Jcompany.GetValue(key).ToString();
                    break;
                    case "address": 
                        _company.companyAddress = Jcompany.GetValue(key).ToString();
                    break;
                    case "description": 
                        _company.description = Jcompany.GetValue(key).ToString();
                    break;
                    case "startDate":
                        _company.memberSince = DateTime.Parse(Jcompany.GetValue(key).ToString());
                    break;
                    default:
                    break;
                }
            }

            companies.Add(_company);
            }  

            System.Console.WriteLine(companies);
            return companies;
        }
        return new List<Company>();
    }

    public static async Task<IList<Member>>  getAllMembers(){
        System.Console.WriteLine(Apicontroller.JWTtoken);
        string apiUrl = "https://app.officernd.com/api/v1/organizations/thehaguetech/members";
        JArray responseMessage = await requestHttp(apiUrl);
        IList<Member> members = new List<Member>();
        
        foreach(JObject Jcompany  in responseMessage){
            
            Member _member =  new Member();
            string[] array = { "_id", "email", "image", "phone", "name", "team" , "description","startDate"};

            IList<string> validatedKeys = validateKeyValues(array, Jcompany);
            
            foreach(string key in validatedKeys){
                switch(key){
                    case "_id": 
                        _member.profileID = Jcompany.GetValue(key).ToString();
                    break;
                    case "email": 
                        _member.email = Jcompany.GetValue(key).ToString();
                    break;
                    case "image": 
                        _member.picture = Jcompany.GetValue(key).ToString();
                    break;
                    case "name": 
                        _member.teamID = Jcompany.GetValue(key).ToString();
                    break;
                    case "team": 
                        _member.teamID = Jcompany.GetValue(key).ToString();
                    break;
                    case "description": 
                        _member.description = Jcompany.GetValue(key).ToString();
                    break;
                    case "phone": 
                        _member.phone = Jcompany.GetValue(key).ToString();
                    break;
                    default:
                    break;
                }
            }

            members.Add(_member);
            }  

        return members;

    }
       public static async Task<IList<Member>> getMember(string id){
        System.Console.WriteLine(Apicontroller.JWTtoken);
        string apiUrl = "https://app.officernd.com/api/v1/organizations/thehaguetech/members?_id=" + id; 
        JArray responseMessage = await requestHttp(apiUrl);
        IList<Member> members = new List<Member>();
        
        foreach(JObject Jcompany  in responseMessage){
            
            Member _member =  new Member();
            string[] array = { "_id", "email", "image", "phone", "name", "team" , "description","startDate"};

            IList<string> validatedKeys = validateKeyValues(array, Jcompany);
            
            foreach(string key in validatedKeys){
                switch(key){
                    case "_id": 
                        _member.profileID = Jcompany.GetValue(key).ToString();
                    break;
                    case "email": 
                        _member.email = Jcompany.GetValue(key).ToString();
                    break;
                    case "image": 
                        _member.picture = Jcompany.GetValue(key).ToString();
                    break;
                    case "name": 
                        _member.teamID = Jcompany.GetValue(key).ToString();
                    break;
                    case "team": 
                        _member.teamID = Jcompany.GetValue(key).ToString();
                    break;
                    case "description": 
                        _member.description = Jcompany.GetValue(key).ToString();
                    break;
                    case "phone": 
                        _member.phone = Jcompany.GetValue(key).ToString();
                    break;
                    default:
                    break;
                }
            }

            members.Add(_member);
            }  

        return members;

    }
    }
}