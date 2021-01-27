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
    public class MumblingController : ControllerBase
    {
        [HttpGet("{characterString}")]
        public string Mumbling(string characterString)
        {
            var answer = "";
            for (var index = 0; index < characterString.Length; index++)
            {
                var upperCase = characterString[index].ToString().ToUpper();
                var lowerCase = characterString[index].ToString().ToLower();
                answer += upperCase;
                for (var i = 0; i < index; i++)
                {
                    answer += lowerCase;
                }
                if (index != characterString.Length - 1)
                {
                    answer += "-";
                }
            }
            return answer;
        }
    }
}