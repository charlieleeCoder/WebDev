﻿
namespace WorkoutTracker.Services.Workout;

public class WorkoutService : IWorkoutService
{
    private static readonly Dictionary<Guid, Models.Workout> _workout = new();
    
    public void CreateWorkout(Models.Workout workout)
    {
        // TODO: Actually store in database

        // Temp solution
        _workout.Add(workout.WorkoutID, workout);
    }

    public Models.Workout GetWorkout(Guid id)
    {
        return _workout[id];
    }

    public void UpsertWorkout(Models.Workout workout)
    {
        _workout[workout.WorkoutID] = workout;
    }

    public void DeleteWorkout(Guid id)
    {
        _workout.Remove(id);
    }
}


