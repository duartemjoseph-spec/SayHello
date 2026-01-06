using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SayHelloApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
    
    // ASSIGNMENT SAY HELLO - ENDPOINT: Personalized Greeting Endpoint
[HttpGet]
[Route("Greeting/{name}")]
public string GetGreeting(string name)
{
    return $"Hello, {name}.";
}
    }
}
