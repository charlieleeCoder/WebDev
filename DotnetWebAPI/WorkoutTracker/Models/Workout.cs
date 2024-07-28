/*
    Contains constructors with null Exercise array for AddExerciseRequest 
    and with Exercise array for Upsert variant.
*/

using WorkoutTracker.Exercise;
using ExerciseNamespace = WorkoutTracker.Services.Exercise;

namespace WorkoutTracker.Models;

public class Workout
{
    public Guid WorkoutID                   { get; } = Guid.NewGuid();
    public string WorkoutLocation           { get; }
    public DateTime WorkoutStartDateTime    { get; }
    public string? WorkoutNotes             { get; }

    public Workout(
        Guid workoutID,
        string workoutLocation, 
        DateTime workoutStartDateTime, 
        string workoutNotes
    )
    {
        WorkoutID = workoutID;
        WorkoutLocation = workoutLocation;
        WorkoutStartDateTime = workoutStartDateTime;
        WorkoutNotes = workoutNotes;
    }

        public Workout(
        string workoutLocation, 
        DateTime workoutStartDateTime, 
        string workoutNotes
    )
    {
        WorkoutID = Guid.NewGuid();
        WorkoutLocation = workoutLocation;
        WorkoutStartDateTime = workoutStartDateTime;
        WorkoutNotes = workoutNotes;
    }
}