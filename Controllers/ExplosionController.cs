using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{numberString}")]
        public string Explosion(string numberString)
        {
            var answer = "";
            for (var index = 0; index < numberString.Length; index++)
            {
                var sInt = int.Parse(numberString[index].ToString());
                for (var j = 0; j < sInt; j++)
                {
                    answer += numberString[index];
                }
            }
            return answer;
        }
    }
}
