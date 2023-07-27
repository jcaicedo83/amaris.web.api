using amaris.web.api.core.dto;
using amaris.web.api.core.interfaces.repository;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace amaris.web.api.infraestructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration _config;
        private string _url;
        public EmployeeRepository(IConfiguration configuration)
        {
            _config = configuration;
            _url = _config["remoteUrl"];
        }

        public Employee Get(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"{_url}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                string jsonResponse=string.Empty;
                HttpResponseMessage _response =  client.GetAsync($"employee/{id}").Result;

                if (_response.IsSuccessStatusCode)
                {
                    jsonResponse = _response.Content.ReadAsStringAsync().Result;
                }

                    var result = JsonConvert.DeserializeObject<SingleDummyResponse>(jsonResponse);
                    return result.data;
                

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<Employee> Get()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri($"{_url}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                string jsonResponse=string.Empty;
                HttpResponseMessage _response = client.GetAsync($"employees").Result;
                if (_response.IsSuccessStatusCode)
                {
                    jsonResponse = _response.Content.ReadAsStringAsync().Result;
                }

                var result = JsonConvert.DeserializeObject<DummyResponse>(jsonResponse);
                return result.data;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}