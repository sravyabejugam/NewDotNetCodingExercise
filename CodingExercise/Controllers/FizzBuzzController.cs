using CodingExercise.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace CodingExercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzz _fizzBuzz;

        public FizzBuzzController(IFizzBuzz fizzbuzz)
        {
            _fizzBuzz = fizzbuzz;
            
        }

        [HttpPost(Name = "GetFizzBuZZ")]
        public ArrayList Post([FromBody] ArrayList arr)
        {
            var arrlist3 = _fizzBuzz.GetandPost(arr);
            
            return arrlist3;
        }
    }
}
