using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Workout;

/*
    A controller to handle the creation and updating of the workout.

    Most relevant information is stored in each object within the List<Exercise>, 
    so the Upsert is for managing location and date meta data only.

    Deleting the workout will remove all Exercises stored in the List<T> also.
 */

namespace WorkoutTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkoutsController : ControllerBase
    {
        [HttpPost()]
        public IActionResult CreateWorkout(CreateWorkoutRequest request)
        {
            return Ok(request);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetWorkout(Guid id)
        {
            return Ok(id);
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpsertWorkout(UpsertWorkoutRequest request)
        {
            return Ok(request);
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteWorkout(Guid id)
        {
            return Ok(id);
        }
    }
}
