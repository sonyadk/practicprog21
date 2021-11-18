using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WebApplication1.Requests;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("test")]
    public class WeatherForecastController : Controller
    {
        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            return this.Json(new { result = "Hello World!" });
        }

        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("get_square")]
        public async Task<IActionResult> GetSquare()
        {
            WebApplicationRequest request = new WebApplicationRequest(this.Request);

            double square = 0.5 * request.First * request.Second;

            MyClassResponse res = new MyClassResponse();
            res.Success = "success";
            res.Version = "1.0";
            res.Result = square;
            return this.Json(res);
        }
    }
}

