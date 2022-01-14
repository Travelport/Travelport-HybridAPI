using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HybridAPIFlow.BL
{
    public class cOAuthCredentials
    {
        public string OAuthEndPoint { get; set; }
        public string OAuthUsername { get; set; }
        public string OAuthPassword { get; set; }
        public string OAuthClientId { get; set; }
        public string OAuthSecret { get; set; }
        public string AccessGroup { get; set; }
        public const string grant_type = "password";
    }

    internal class cOAuthResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string refresh_token { get; set; }
        public string id_token { get; set; }
    }
    internal class Token
    {
        [JsonProperty("access_token")]
        public string AccessToken
        {
            get;
            set;
        }
        [JsonProperty("token_type")]
        public string TokenType
        {
            get;
            set;
        }
        [JsonProperty("expires_in")]
        public int ExpiresIn
        {
            get;
            set;
        }

        [JsonProperty("id_token")]
        public string IdToken
        {
            get;
            set;
        }
    }

    public class OAuthHelper
    {
        public static string getOAuthToken(cOAuthCredentials OAuthCred)
        {
            var client = new HttpClient();
            var form = new Dictionary<string, string> {
            {
                "grant_type",
                "password"
            },
            {
                "username",
                OAuthCred.OAuthUsername
            },
            {
                "password",
                OAuthCred.OAuthPassword
            },
            {
                "client_id",
                OAuthCred.OAuthClientId
            },
            {
                "client_secret",
                OAuthCred.OAuthSecret
            },
            };
            var tokenResponse = client.PostAsync(OAuthCred.OAuthEndPoint, new FormUrlEncodedContent(form)).Result;
            var token = tokenResponse.Content.ReadAsAsync<Token>(new[] { new JsonMediaTypeFormatter() }).Result;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);

            return token.AccessToken;

        }
    }

}
