namespace WorkoutTracker.Exercise;

public record AddExerciseRequest(
    Guid LinkedWorkoutID,
    string ExerciseName,
    int NumberOfSets,
    List<int> WeightEachSet,
    List<int> RepsEachSet,
    string notes
);
