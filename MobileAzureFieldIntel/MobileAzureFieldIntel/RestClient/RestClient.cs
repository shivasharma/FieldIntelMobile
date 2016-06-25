using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MobileAzureFieldIntel.Model;
using Newtonsoft.Json;

namespace Plugin.RestClient
{
    /// <summary>
    /// RestClient implements methods for calling CRUD operations
    /// using HTTP.
    /// </summary>
    public class RestClient<T>
    {
      //  private const string WebServiceUrl = "http://localhost:64980/api/Employees";
        private const string WebServiceUrl = "http://employeesdirectory.azurewebsites.net/api/Employees/";

        public async Task<List<T>> GetAsync()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(WebServiceUrl);

            var listemployees = JsonConvert.DeserializeObject<List<T>>(json);

            return listemployees;
        }
        //public async Task<List<Employee>> GetAsync()
        //{
        //    var client = new HttpClient();
        //    client.BaseAddress=new Uri(WebServiceUrl);
        //    var json = await client.GetStringAsync(WebServiceUrl);
        //    var response = await client.GetAsync(client.BaseAddress);
        //    var JsonResult = response.Content.ReadAsStringAsync().Result;
        //    var employee = JsonConvert.DeserializeObject<List<Employee>>(JsonResult);
        //    return  employee;
        //    // var employees = JsonConvert.DeserializeObject<List<T>>(json);

        //    //return employees;
        //}

        public async Task<bool> PostAsync(T t)
        {
            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(t);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpClient.PostAsync(WebServiceUrl, httpContent);

            return result.IsSuccessStatusCode;
        }

        public async Task<bool> PutAsync(int id, T t)
        {
            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(t);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpClient.PutAsync(WebServiceUrl + id, httpContent);

            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id, T t)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.DeleteAsync(WebServiceUrl + id);

            return response.IsSuccessStatusCode;
        }
    }
}
