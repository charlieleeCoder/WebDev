
namespace WorkoutTracker.Services.Exercise;

public class ExerciseService : IExerciseService
{
    private static readonly Dictionary<Guid, Models.Exercise> _exercise = new();
    public void CreateExercise(Models.Exercise exercise)
    {
        // TODO: Actually store in database

        // Temp solution
        _exercise.Add(exercise.ExerciseID, exercise);
    }

    public void DeleteExercise(Guid id)
    {
        _exercise.Remove(id);;
    }

    public Models.Exercise GetExercise(Guid id)
    {
        return _exercise[id];
    }

    public void UpsertExercise(Models.Exercise exercise)
    {
        _exercise[exercise.ExerciseID] = exercise;
    }
}
