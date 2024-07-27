using ExerciseNamespace = WorkoutTracker.Services.Exercise;

namespace WorkoutTracker.Workout;

public record UpsertWorkoutRequest(
    Guid WorkoutID,
    string WorkoutLocation,
    DateTime WorkoutStartDateTime,
    string WorkoutNotes,
    ExerciseNamespace.Exercise[] Exercises
);

