using Models = WorkoutTracker.Models.Workout;

namespace WorkoutTracker.Services.Workout;

public interface IWorkoutService
{
    void CreateWorkout(Models.Workout workout);
    Models.Workout GetWorkout(Guid id);
    void UpsertWorkout(Models.Workout workout); // Or Models.Workout?
    void DeleteWorkout(Guid id);
}