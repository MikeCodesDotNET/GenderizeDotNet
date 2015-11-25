using System;
using System.Threading.Tasks;
using GenderizeDotNet.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace GenderizeDotNet
{
    public class Client
    {
        public Client()
        {
        }

        public async Task<Response> GenderizeSingleName(string name)
        {           
            if (_client == null)
                _client = new HttpClient();

            Response model;

            var url = string.Format("http://api.genderize.io/?name={0}", name);
            var response = await _client.GetAsync(url);

            var jsonString = response.Content.ReadAsStringAsync();
            jsonString.Wait();
            model = JsonConvert.DeserializeObject<Response>(jsonString.Result);

            return model;    
        }

        HttpClient _client;
    }
}

