namespace WorkoutTracker.Workout;

public record CreateWorkoutRequest(
    string WorkoutLocation,
    DateTime WorkoutStartDateTime,
    string WorkoutNotes
);
