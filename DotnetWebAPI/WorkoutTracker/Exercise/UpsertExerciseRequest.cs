namespace WorkoutTracker.Exercise;

public record UpsertExerciseRequest(
    Guid LinkedWorkoutID,
    Guid ExerciseID,
    string ExerciseName,
    int NumberOfSets,
    List<int> WeightEachSet,
    List<int> RepsEachSet,
    string notes
);
