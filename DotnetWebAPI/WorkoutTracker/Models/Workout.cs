/*
    Contains constructors with null Exercise array for AddExerciseRequest and with Exercise array for Upsert variant.
*/

using ExerciseNamespace = WorkoutTracker.Services.Exercise;

namespace WorkoutTracker.Models;

public class Workout
{
    public Guid WorkoutID                               { get; } = new Guid();
    public string WorkoutLocation                       { get; }
    public DateTime WorkoutStartDateTime                { get; }
    public string WorkoutNotes                          { get; }
    public List<ExerciseNamespace.Exercise>? Exercises  { get; set; } = default;

    public Workout(
        string workoutLocation, 
        DateTime workoutStartDateTime, 
        string workoutNotes, 
        List<ExerciseNamespace.Exercise>? exercises
    )
    {
        WorkoutLocation = workoutLocation;
        WorkoutStartDateTime = workoutStartDateTime;
        WorkoutNotes = workoutNotes;
        Exercises = exercises;
    }

    public Workout(
        string workoutLocation, 
        DateTime workoutStartDateTime, 
        string workoutNotes
    )
    {
        WorkoutLocation = workoutLocation;
        WorkoutStartDateTime = workoutStartDateTime;
        WorkoutNotes = workoutNotes;
    }
}