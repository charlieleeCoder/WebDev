using Models = WorkoutTracker.Models.Exercise;

namespace WorkoutTracker.Workout;

public record UpsertWorkoutRequest(
    Guid WorkoutID,
    string WorkoutLocation,
    DateTime WorkoutStartDateTime,
    string? WorkoutNotes,
    List<Models.Exercise>? Exercises
);

