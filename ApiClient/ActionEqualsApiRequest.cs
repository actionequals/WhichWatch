using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AERestAPI.ApiClient {
    public class ActionEqualsApiRequest<T> {

        string BaseUrl = "https://actionequals.com/api/";
        string Username = "Your Actionequals.com username (email)";
        string Password = "Your ActionEquals Password";
        string ApiKey = "Your APIKEY";
        public HttpClient httpClient { get; set; }
        string TableName;

        public string Endpoint { get; set; }
        public ActionEqualsApiRequest(HttpClient client, string tableName) {
            TableName = tableName;
            httpClient = client;
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", Username, Password))));
            
        }

        public async Task<T[]> GetAllAsync() {
            Endpoint = $"{BaseUrl}{ApiKey}?f={TableName}";
            var answer = await httpClient.GetFromJsonAsync<T[]>(Endpoint, serializationOptions());
            return answer;
        }

        public async Task<T> GetByKey(string key) {
            Endpoint = $"{BaseUrl}{ApiKey}?f={TableName}&Key={key}";
            var answer = await httpClient.GetFromJsonAsync<T>(Endpoint, serializationOptions());
            return (answer);
        }

        public async Task<bool> Insert(T dto) {
            Endpoint = $"{BaseUrl}{ApiKey}?f={TableName}";
            return (await httpClient.PostAsJsonAsync(Endpoint, dto, serializationOptions())).IsSuccessStatusCode;
        }

        public async Task Delete(string key) {
            Endpoint = $"{BaseUrl}{ApiKey}?f={TableName}&Key={key}";
            await httpClient.DeleteAsync(Endpoint);
        }

        public async Task Update(string key, T updatedDto) {
            Endpoint = $"{BaseUrl}{ApiKey}?f={TableName}&Key={key}";
            await httpClient.PutAsJsonAsync(Endpoint, updatedDto, serializationOptions());
        }

        JsonSerializerOptions serializationOptions() {
            return new JsonSerializerOptions { DictionaryKeyPolicy = null, PropertyNamingPolicy = null };
        }
    }
}
