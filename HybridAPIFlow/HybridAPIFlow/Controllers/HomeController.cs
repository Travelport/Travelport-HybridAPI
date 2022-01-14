using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HybridAPIFlow.BL;
using Newtonsoft.Json;

namespace HybridAPIFlow.Controllers
{  
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        private const string version = "11";
        private const string service = "air/catalog/search";

        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            StringEscapeHandling = StringEscapeHandling.EscapeHtml,
            Formatting = Formatting.Indented,
        };

        public string ExecuteSearchPlus(string fromAiport, string toAirport, string airlineCode, 
            string DepartureDate, string ReturnDate)
        {
            if (fromAiport.Length != 3 && toAirport.Length != 3
                && airlineCode.Length != 2 && DepartureDate.Length == 0) // Validate input server side
            {
                return string.Empty;
            }
            else
            {

                string accessGroup = ConfigurationManager.AppSettings["jsonAPI_AccessGroup"];
                string jsonAPI_Endpoint = ConfigurationManager.AppSettings["jsonAPI_Endpoint"];
                object token = Session["token"];

                if (token == null)
                {
                    //get OAuthToken
                    cOAuthCredentials cred = new cOAuthCredentials()
                    {
                        OAuthEndPoint = ConfigurationManager.AppSettings["jsonAPI_OAuthEndPoint"],
                        OAuthUsername = ConfigurationManager.AppSettings["jsonAPI_OAuthUsername"],
                        OAuthPassword = ConfigurationManager.AppSettings["jsonAPI_OAuthPassword"],
                        OAuthClientId = ConfigurationManager.AppSettings["jsonAPI_OAuthClientId"],
                        OAuthSecret = ConfigurationManager.AppSettings["jsonAPI_OAuthSecret"],
                        AccessGroup = accessGroup
                    };
                    token = OAuthHelper.getOAuthToken(cred);
                    //
                }

                if (token != null && token.ToString() != string.Empty)
                {
                    Session.Add("token", token);
                   
                    return 
                     JsonConvert.SerializeObject(APIHelper.ExecuteSearchPlus(token.ToString(), jsonAPI_Endpoint,
                         version, service, accessGroup, fromAiport, toAirport,
                         DepartureDate, ReturnDate, airlineCode) , serializerSettings);                   
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string ExecuteAirPrice(string segments, string Tier, string returnSegments="")
        {
            string BranchId = ConfigurationManager.AppSettings["xmlBranchId"];
            string xmlUserName = ConfigurationManager.AppSettings["xmlUsername"];
            string xmlPassword = ConfigurationManager.AppSettings["xmlPassword"];
            string xmlEndpoint = ConfigurationManager.AppSettings["xmlEndpoint"];

            List<FlightSegments> flights = JsonConvert.DeserializeObject<List<FlightSegments>>(segments);
            flights.Select(c => { c.Group = 0; return c; }).ToList();

            if (returnSegments != "")
            {
                List<FlightSegments> returnflights = JsonConvert.DeserializeObject<List<FlightSegments>>(returnSegments);
                returnflights.Select(c => { c.Group = 1; return c; }).ToList();

                flights.AddRange(returnflights);                
            }
                

            return JsonConvert.SerializeObject(APIHelper.ExecuteAirPrice(BranchId, xmlUserName, xmlPassword, xmlEndpoint, flights, Tier));
        }
        
    }
}