using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Exercise;

/*
    A controller to handle the creation and updating of the exercises.

    These are a component of each workout, i.e. each Workout has a List<Exercise>.

    Each exercise stores exercise name, weight array, rep array, etc.
 */

namespace WorkoutTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExercisesController : ControllerBase
    {
        [HttpPost()]
        public IActionResult CreateExercise(AddExerciseRequest request)
        {
            return Ok(request);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetExercise(Guid id)
        {
            return Ok(id);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpsertExercise(UpsertExerciseRequest request)
        {
            return Ok(request);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteExercise(Guid id)
        {
            return Ok(id);
        }
    }
}
