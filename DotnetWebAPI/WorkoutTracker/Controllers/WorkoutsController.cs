/*
    A controller to handle the creation and updating of the workout.

    Most relevant information is stored in each object within the List<Exercise>, 
    so the Upsert is for managing location and date meta data only.

    Deleting the workout will remove all Exercises stored in the List<T> also.
*/

using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Workout;
using WorkoutTracker.Services.Workout;

namespace WorkoutTracker.Controllers;

[ApiController]
[Route("[controller]")]
public class WorkoutsController : ControllerBase
{
    private readonly IWorkoutService _workoutService;
    public WorkoutsController(IWorkoutService workoutService)
    {
        _workoutService = workoutService;
    }

    [HttpPost]
    public IActionResult CreateWorkout(CreateWorkoutRequest request)
    {
        var workout = new Models.Workout(
            request.WorkoutLocation,
            request.WorkoutStartDateTime,
            request.WorkoutNotes!
        );

        // TODO: Save workout to database. Currently stored in dict.
        _workoutService.CreateWorkout(workout);

        var response = new WorkoutResponse(
            workout.WorkoutID,
            workout.WorkoutLocation,
            workout.WorkoutStartDateTime,
            workout.WorkoutNotes
        );

        return CreatedAtAction(
            actionName: nameof(GetWorkout),
            routeValues: new { id = workout.WorkoutID },
            value: response
        );
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetWorkout(Guid id)
    {
        Models.Workout workout = _workoutService.GetWorkout(id);

        var response = new WorkoutResponse(
            WorkoutID: workout.WorkoutID,
            WorkoutLocation: workout.WorkoutLocation, 
            WorkoutStartDateTime: workout.WorkoutStartDateTime, 
            WorkoutNotes: workout.WorkoutNotes
        );

        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertWorkout(Guid id, UpsertWorkoutRequest request)
    {   
        
        // Can overwrite existing object with updated version, or insert new
        var workout = new Models.Workout(
            id,
            request.WorkoutLocation,
            request.WorkoutStartDateTime,
            request.WorkoutNotes!
        );

        _workoutService.UpsertWorkout(workout);
        
        return Ok(request);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteWorkout(Guid id)
    {
        _workoutService.DeleteWorkout(id);
        return NoContent();
    }
}
