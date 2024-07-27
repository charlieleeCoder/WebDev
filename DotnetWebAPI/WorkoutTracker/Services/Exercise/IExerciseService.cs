using Models = WorkoutTracker.Models.Exercise;

namespace WorkoutTracker.Services.Exercise;

public interface IExerciseService
{
    void CreateExercise(Models.Exercise exercise);
    Models.Exercise GetExercise(Guid id);
    void UpsertExercise(Models.Exercise exercise); 
    void DeleteExercise(Guid id);
}