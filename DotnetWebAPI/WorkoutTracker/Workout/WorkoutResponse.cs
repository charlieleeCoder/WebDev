using Models = WorkoutTracker.Models.Exercise;

namespace WorkoutTracker.Workout;

public record WorkoutResponse(
    Guid WorkoutID,
    string WorkoutLocation,
    DateTime WorkoutStartDateTime,
    string? WorkoutNotes
);