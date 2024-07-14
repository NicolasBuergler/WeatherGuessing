using Microsoft.AspNetCore.Mvc;

namespace WeatherGuessingBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizManagerController : ControllerBase
    {
        [HttpGet(Name = "GetQuiz")]
        public Quiz GetQuiz()
        {
            return new Quiz() { City = "Zürich", TempratureOptions = new float[] {15, 20, 22 }  };
        }

        [HttpGet("solution", Name = "GetSolution")]
        public bool GetSolution([FromQuery] float awnser)
        {
            if (awnser == 22)
                return true;
            return false;
        }

    }
}
