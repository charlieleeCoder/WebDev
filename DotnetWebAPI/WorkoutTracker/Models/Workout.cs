/*
    Contains constructors with null Exercise array for AddExerciseRequest 
    and with Exercise array for Upsert variant.
*/

using ExerciseNamespace = WorkoutTracker.Services.Exercise;

namespace WorkoutTracker.Models;

public class Workout
{
    public Guid WorkoutID                   { get; } = Guid.NewGuid();
    public string WorkoutLocation           { get; }
    public DateTime WorkoutStartDateTime    { get; }
    public string? WorkoutNotes             { get; }
    public List<Exercise>? Exercises        { get; set; } = default;

    public Workout(
        Guid workoutID,
        string workoutLocation, 
        DateTime workoutStartDateTime, 
        string workoutNotes, 
        List<Exercise>? exercises
    )
    {
        WorkoutID = workoutID;
        WorkoutLocation = workoutLocation;
        WorkoutStartDateTime = workoutStartDateTime;
        WorkoutNotes = workoutNotes;
        Exercises = exercises;
    }

        public Workout(
        string workoutLocation, 
        DateTime workoutStartDateTime, 
        string workoutNotes, 
        List<Exercise>? exercises
    )
    {
        WorkoutID = Guid.NewGuid();
        WorkoutLocation = workoutLocation;
        WorkoutStartDateTime = workoutStartDateTime;
        WorkoutNotes = workoutNotes;
        Exercises = exercises;
    }
}