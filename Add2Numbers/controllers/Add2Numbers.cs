using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Add2Numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        // ASSIGNMENT ADD 2 NUMBERS - ENDPOINT: Add Two Numbers
        [HttpGet]
        [Route("Add/{num1}/{num2}")]
        public string AddNumbers(int num1, int num2)
        {

            return $"the sum of {num1} and {num2} is {num1 + num2}";
        }
    }
}

