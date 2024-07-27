/*
    A controller to handle the creation and updating of the exercises.

    These are a component of each workout, i.e. each Workout has a List<Exercise>.

    Each exercise stores exercise name, weight array, rep array, etc.
 */

using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Exercise;
using WorkoutTracker.Services.Exercise;

namespace WorkoutTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExercisesController : ControllerBase
    {
        private readonly IExerciseService _exerciseService;
        public ExercisesController(IExerciseService service)
        {
            _exerciseService = service;
        }

        [HttpPost()]
        public IActionResult CreateExercise(AddExerciseRequest request)
        {
            var exercise = new Models.Exercise(
                request.LinkedWorkoutID,
                request.ExerciseName,
                request.NumberOfSets,
                request.WeightEachSet, 
                request.RepsEachSet
            );

             // TODO: Save exercise to database. Currently stored in dict.

            var response = new ExerciseResponse(
                exercise.LinkedWorkoutID,
                exercise.ExerciseID,
                exercise.ExerciseName,
                exercise.NumberOfSets,
                exercise.WeightEachSet, 
                exercise.RepsEachSet,
                exercise.Notes!
            );

            return CreatedAtAction(
                actionName: nameof(GetExercise),
                routeValues: new { id = exercise.ExerciseID },
                value: request
            );
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetExercise(Guid id)
        {
            Models.Exercise exercise = _exerciseService.GetExercise(id);

            var response = new ExerciseResponse(
                LinkedWorkoutID: exercise.LinkedWorkoutID,
                ExerciseID: exercise.ExerciseID, 
                ExerciseName: exercise.ExerciseName, 
                NumberOfSets: exercise.NumberOfSets, 
                WeightEachSet: exercise.WeightEachSet,
                RepsEachSet: exercise.RepsEachSet,
                Notes: exercise.Notes!
            );

            return Ok(response);
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
