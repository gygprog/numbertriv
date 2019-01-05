using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using api.Dto;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class TriviaController : Controller
    {
        // GET api/trivia/number
        [HttpGet("{number}")]
        public async Task<TriviaResponse> Get(int number)
        {
            var httpClient = new HttpClient(); 
            var response = await httpClient.GetAsync("http://numbersapi.com/"+ number + "?json");
            var triviaResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TriviaResponse>(triviaResult);
        }

     
    }
}
