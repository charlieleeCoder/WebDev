namespace WorkoutTracker.Exercise;

public record ExerciseResponse(
    Guid LinkedWorkoutID,
    Guid ExerciseID,
    string ExerciseName,
    int NumberOfSets,
    List<float> WeightEachSet,
    List<int> RepsEachSet,
    string notes
);

