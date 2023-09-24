using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Services
{
    public class CountryService
    {
        private const string serverUrl = "https://restcountries.com/v3.1";

        public async Task<List<Country>> GetAllCountry()
        {
            try
            {
                var url = serverUrl + "/all";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);


                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Error in getting data");
                }
                
                var content = await response.Content.ReadAsStringAsync();
                var countries = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Country>>(content);

                return countries;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
        }

         



        //public async Task<Country> GetByName(string name)
        //{
        //    try
        //    {
        //        var url = serverUrl + $"/name{name}fullText=true";
        //        var httpClient = new HttpClient();
        //        var response = await httpClient.GetAsync(url);


        //        if (!response.IsSuccessStatusCode)
        //        {
        //            throw new Exception("Error in getting data");
        //        }

        //        var content = await response.Content.ReadAsStringAsync();
        //        var countries = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Country>>(content);

                
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //        throw ex;
        //    }
        
    }
}
