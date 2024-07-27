namespace WorkoutTracker.Exercise;

public record UpsertExerciseRequest(
    Guid LinkedWorkoutID,
    Guid ExerciseID,
    string ExerciseName,
    int NumberOfSets,
    List<float> WeightEachSet,
    List<int> RepsEachSet,
    string? Notes
);
