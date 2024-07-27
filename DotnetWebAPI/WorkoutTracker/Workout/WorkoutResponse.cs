using ExerciseNamespace = WorkoutTracker.Services.Exercise;

namespace WorkoutTracker.Workout;

public record WorkoutResponse(
    Guid WorkoutID,
    string WorkoutLocation,
    DateTime WorkoutStartDateTime,
    string? WorkoutNotes,
    List<ExerciseNamespace.Exercise>? Exercises
);

