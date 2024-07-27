using Models = WorkoutTracker.Models.Exercise;

namespace WorkoutTracker.Services.Exercise;

public interface IExerciseService
{
    void CreateExercise(Models.Exercise exercise);
}