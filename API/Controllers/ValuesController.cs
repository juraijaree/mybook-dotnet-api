using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class ValuesController : ControllerBase
  {
    private readonly DataContext _context;
    public ValuesController(DataContext context)
    {
      _context = context;
    }

    // GET api/values
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Value>>> Get()
    {
        var values = await _context.Values.ToListAsync();

        return Ok(values);
    }

    // GET api/values/4
    [HttpGet("{id}")]
    public async Task<ActionResult<Value>> Get(int id)
    {
        var value = await _context.Values.FindAsync(id);

        return Ok(value);
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {

    }

    // PUT api/values/4
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {

    }

    // DELETE api/values/4
    [HttpDelete("{id}")]
    public void Delete(int id)
    {

    }
  }
}


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;

// namespace API.Controllers
// {
//     [ApiController]
//     [Route("[controller]")]
//     public class WeatherForecastController : ControllerBase
//     {
//         private static readonly string[] Summaries = new[]
//         {
//             "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//         };

//         private readonly ILogger<WeatherForecastController> _logger;

//         public WeatherForecastController(ILogger<WeatherForecastController> logger)
//         {
//             _logger = logger;
//         }

//         [HttpGet]
//         public IEnumerable<WeatherForecast> Get()
//         {
//             var rng = new Random();
//             return Enumerable.Range(1, 5).Select(index => new WeatherForecast
//             {
//                 Date = DateTime.Now.AddDays(index),
//                 TemperatureC = rng.Next(-20, 55),
//                 Summary = Summaries[rng.Next(Summaries.Length)]
//             })
//             .ToArray();
//         }
//     }
// }
