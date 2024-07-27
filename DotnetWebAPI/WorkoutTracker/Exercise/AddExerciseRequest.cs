namespace WorkoutTracker.Exercise;

public record AddExerciseRequest(
    Guid LinkedWorkoutID,
    string ExerciseName,
    int NumberOfSets,
    List<float> WeightEachSet,
    List<int> RepsEachSet,
    string? Notes
);
