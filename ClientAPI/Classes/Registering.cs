using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientAPI.Classes
{
    public static class Registering
    {
        // регистрация
        public static string Register(string email, string password, string APP_PATH)
        {
            var registerModel = new
            {
                Email = email,
                Password = password,
                ConfirmPassword = password
            };
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(APP_PATH + "/api/Account/Register", registerModel).Result;
                return response.StatusCode.ToString();
            }
        }

        // создаем http-клиента с токеном 
        static HttpClient CreateClient(string accessToken = "")
        {
            var client = new HttpClient();
            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            }
            return client;
        }

        // получаем информацию о клиенте 
        public static string GetUserInfo(string token, string APP_PATH)
        {
            using (var client = CreateClient(token))
            {
                var response = client.GetAsync(APP_PATH + "/api/Account/UserInfo").Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }

        // обращаемся по маршруту api/values 
        public static string GetValues(string token, string APP_PATH)
        {
            using (var client = CreateClient(token))
            {
                var response = client.GetAsync(APP_PATH + "/api/Sections").Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }

        // получение токена
        public static Dictionary<string, string> GetTokenDictionary(string userName, string password, string APP_PATH)
        {
            var pairs = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>( "grant_type", "password" ),
                    new KeyValuePair<string, string>( "username", userName ),
                    new KeyValuePair<string, string> ( "Password", password )
                };
            var content = new FormUrlEncodedContent(pairs);

            using (var client = new HttpClient())
            {
                var response =
                    client.PostAsync(APP_PATH + "/Token", content).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                // Десериализация полученного JSON-объекта
                Dictionary<string, string> tokenDictionary =
                    JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                return tokenDictionary;
            }
        }
    }
}
