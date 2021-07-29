using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WAFApi.Models;

namespace WAFApi.Controllers
{
    [ApiController]
    [Route("api/waf")]
    public class WafController : ControllerBase
    {
        public WafController()
        {
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] WafObject wafObject)
        {

            var mappedData = new
            {
                FQDN = wafObject.SiteNamne,
                Hotel = wafObject.Hotel,
                Environment = wafObject.Environment,
                WdUser = wafObject.UGUser,
                Nets = wafObject.Nets,
                AppUser = wafObject.AppUser,
                AppUserPW = wafObject.AppUserPW
            };

            
            using FileStream createStream = System.IO.File.Create(@"C:\Users\bx9518\Desktop\WAFautomation\test\waf-data.txt");
            await JsonSerializer.SerializeAsync(createStream, mappedData);

            return Ok();
        }
    }
}
