using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppService.ELX.Spec.Perf._2.Controllers
{
    public class ReproController : Controller
    {
        static Lazy<HttpClient> client = new Lazy<HttpClient>();
        public async Task<string> Index()
        {
            HttpClient c = client.Value;
            HttpResponseMessage response = await c.GetAsync("https://juzhu500.azurewebsites.net/");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            return "Done";
        }
    }
}
