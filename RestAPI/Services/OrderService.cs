using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Services
{
    public class OrderService
    {
        private const string serverUrl = "https://reqbin.com/echo/post/json";
        public HttpClient _httpClient;

        public OrderService()
        {
            _httpClient = new HttpClient();
        }
        public async Task AddOrder(Order order)
        {
            try
            {
                // e konverton ne string objektin
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(order);
                //mbasi eshte kthyer ne string e shton si bodey tek requesti
                using HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage res = await _httpClient.PostAsync(serverUrl, content);
                Console.WriteLine(await res.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
        }
    }
}
