/*
    The model for an Exercise, a component of a workout.

    Stores data for each set in a list for reps, weight, etc.
*/

namespace WorkoutTracker.Models;

public class Exercise
{
    public Guid LinkedWorkoutID         { get; }
    public Guid ExerciseID              { get; } = new Guid();
    public string ExerciseName          { get; }
    public int NumberOfSets             { get; }
    public List<float> WeightEachSet    { get; }
    public List<int> RepsEachSet        { get; }
    public string? Notes                { get; set; } = default;

    public Exercise(
        Guid linkedWorkoutID, 
        string exerciseName, 
        int numberOfSets, 
        List<float> weightEachSet, 
        List<int> repsEachSet, 
        string? notes = null
    )
    {
        LinkedWorkoutID = linkedWorkoutID;
        ExerciseName = exerciseName;
        NumberOfSets = numberOfSets;
        WeightEachSet = weightEachSet;
        RepsEachSet = repsEachSet;
        Notes = notes;
    }
}